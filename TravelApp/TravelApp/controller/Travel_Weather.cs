using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelApp;

namespace Weather_space
{
    public delegate void Delegate_init();
    public partial class Travel_Weather : UserControl
    {
        public Delegate_init init;
        ChangePanel changePanel;

        public Travel_Weather(ChangePanel changePanel)
        {
            InitializeComponent();
            comboBoxProvince.SelectedIndexChanged += ComboBoxProvince_SelectedIndexChanged;
            comboBoxCity.SelectedIndexChanged += comboBoxCity_SelectedIndexChanged;
            buttonSearch.Click += buttonSearch_Click;
            buttonAbout.Click += buttonAbout_Click;
            this.changePanel = changePanel;
        }
        // 在UI线程上调用操作
        public void InvokeToForm(Action action) => this.Invoke(action);

        // 在UI线程上开始调用操作
        public void BeginInvokeToForm(Action action) => this.BeginInvoke(action);
        // 绑定省份数据到comboBoxProvince
        private void BindProvince()
        {
            // 确保UI更新在主线程上执行
            this.InvokeToForm(() =>
            {
                comboBoxProvince.ComboBox.ValueMember = "ID"; // 设置值成员
                comboBoxProvince.ComboBox.DisplayMember = "Name"; // 设置显示成员
            });
            // 获取省份数据
            PlaceModel[] provinces = Place.GetProvinces();
            if (provinces != null)
            {
                // 设置数据源
                this.InvokeToForm(() => comboBoxProvince.ComboBox.DataSource = provinces);
            }
        }
        // 绑定城市数据到comboBoxCity
        private void BindCity()
        {
            PlaceModel city = null;
            // 确保UI更新在主线程上执行
            this.InvokeToForm(() =>
            {
                comboBoxCity.ComboBox.ValueMember = "ID"; // 设置值成员
                comboBoxCity.ComboBox.DisplayMember = "Name"; // 设置显示成员
                city = comboBoxProvince.ComboBox.SelectedItem as PlaceModel; // 获取选中的省份
            });
            if (city != null)
            {
                // 获取城市数据
                PlaceModel[] citys = Place.GetCitys(city);
                // 设置数据源
                this.InvokeToForm(() => comboBoxCity.ComboBox.DataSource = citys);
            }
        }
        // 绑定地区数据到comboBoxDistrict
        private void BindDistrict()
        {
            PlaceModel province = null;
            PlaceModel city = null;
            // 确保UI更新在主线程上执行
            this.InvokeToForm(() =>
            {
                comboBoxDistrict.ComboBox.ValueMember = "ID"; // 设置值成员
                comboBoxDistrict.ComboBox.DisplayMember = "Name"; // 设置显示成员
                province = comboBoxProvince.ComboBox.SelectedItem as PlaceModel; // 获取选中的省份
                city = comboBoxCity.ComboBox.SelectedItem as PlaceModel; // 获取选中的城市
            });
            if (province != null && city != null)
            {
                // 获取地区数据
                PlaceModel[] districts = Place.GetDistricts(province, city);
                // 设置数据源
                this.InvokeToForm(() => comboBoxDistrict.ComboBox.DataSource = districts);
            }
            else
            {
                // 更新状态标签，提示加载错误
                //this.InvokeToForm(() => lblStatus.Text = "地区加载错误，请确保联网正确");
            }
        }

        // 主窗体加载事件处理


        // 当省份选择更改时，绑定相应的城市数据
        private void ComboBoxProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindCity();
        }

        // 当城市选择更改时，绑定相应的地区数据
        private void comboBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindDistrict();
        }

        // 搜索按钮点击事件处理
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            PlaceModel province = null, city = null, district = null;
            // 确保UI更新在主线程上执行
            this.InvokeToForm(() =>
            {
                // 获取选中的省、市、区
                province = this.comboBoxProvince.ComboBox.SelectedItem as PlaceModel;
                city = this.comboBoxCity.ComboBox.SelectedItem as PlaceModel;
                district = this.comboBoxDistrict.ComboBox.SelectedItem as PlaceModel;
            });
            if (province != null && city != null && district != null)
            {
                // 更新状态标签为“查询中”
                //this.InvokeToForm(() => lblStatus.Text = "查询中");
                // 在后台任务中执行天气查询
                Task.Factory.StartNew(() =>
                {
                    WeatherDetail detail = this.Search(province, city, district); // 执行查询
                    this.Invoke(new Action(() =>
                    {
                        this.SetWeather(detail); // 更新天气信息到UI
                        //lblStatus.Text = "已完成"; // 更新状态标签为“已完成”
                    }));
                }).ContinueWith(t =>
                {
                    // 如果任务出现故障，更新状态标签
                    if (t.IsFaulted)
                    {
                        //this.InvokeToForm(() => lblStatus.Text = "查询错误，请确保联网正确");
                    }
                });
            }
        }

        // 将天气详细信息更新到UI
        private void SetWeather(WeatherDetail detail)
        {
            // 更新前7天的天气信息
            WeatherDay[] weatherDays = new WeatherDay[] { weatherDay1, weatherDay2, weatherDay3, weatherDay4, weatherDay5, weatherDay6, weatherDay7 };
            for (int i = 0; i < weatherDays.Length; i++)
            {
                weatherDays[i].Day = detail.Day_1To7[i] ?? ""; // 设置日期
                weatherDays[i].Info = detail.Info_1To7[i] ?? ""; // 设置信息
                weatherDays[i].Temperature = detail.Temperature_1To7[i] ?? ""; // 设置温度
                weatherDays[i].Wind = detail.Wind_1To7[i] ?? ""; // 设置风力
                weatherDays[i].WeatherStatus = detail.WeatherStatus_1To7[i]; // 设置天气状态


            }
            //今天的天气
            switch (weatherDays[0].WeatherStatus)
            {
                case WeatherStatus.Qing:
                    MessageBox.Show("今天天气很好，您可以放心出行！", "天气提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case WeatherStatus.Duoyun:
                    MessageBox.Show("今天多云，可能会下雨，请小心！", "天气提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case WeatherStatus.Yin:
                    MessageBox.Show("今天阴天，可能会下雨，请小心！", "天气提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case WeatherStatus.Zhenyu:
                    MessageBox.Show("今天有阵雨，出门请带好雨伞！", "天气提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case WeatherStatus.Leizhenyu:
                    MessageBox.Show("今天有雷阵雨，为了安全尽量不要到室外哦！", "天气提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case WeatherStatus.LeizhenyuBingpao:
                    MessageBox.Show("今天有雷阵雨冰雹，为了安全尽量不要到室外哦！", "天气提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case WeatherStatus.Yujiaxue:
                    MessageBox.Show("今天有雨夹雪，请注意保暖！", "天气提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case WeatherStatus.Xiaoyu:
                    MessageBox.Show("今天有小雨，出门请带好雨伞！", "天气提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case WeatherStatus.Zhongyu:
                    MessageBox.Show("今天有中雨，出门请带好雨伞！", "天气提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case WeatherStatus.Dayu:
                    MessageBox.Show("今天有大雨，出门请带好雨伞，注意安全！", "天气提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case WeatherStatus.Baoyu:
                    MessageBox.Show("今天有暴雨，出门请带好雨伞，注意安全！", "天气提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case WeatherStatus.Dabaoyu:
                    MessageBox.Show("今天有特大暴雨，出门请带好雨伞，注意安全！", "天气提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default:
                    MessageBox.Show("欢迎使用行迹精灵！", "天气提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }

            // 更新后8天的天气信息
            //WeatherDayMore[] weatherDaysMore = new WeatherDayMore[] { weatherDayMore1, weatherDayMore2, weatherDayMore3, weatherDayMore4, weatherDayMore5, weatherDayMore6, weatherDayMore7, weatherDayMore8 };
            //for (int i = 0; i < weatherDaysMore.Length; i++)
            //{
            //    weatherDaysMore[i].Day = detail.Day_7To15[i] ?? ""; // 设置日期
            //    weatherDaysMore[i].Info = detail.Info_7To15[i] ?? ""; // 设置信息
            //   weatherDaysMore[i].Temperature = detail.Temperature_7To15[i] ?? ""; // 设置温度
            //   weatherDaysMore[i].Wind1 = detail.Wind1_7To15[i] ?? ""; // 设置风力1
            //  weatherDaysMore[i].Wind2 = detail.Wind2_7To15[i] ?? ""; // 设置风力2
            //  weatherDaysMore[i].WeatherStatus = detail.WeatherStatus_7To15[i]; // 设置天气状态
            //}
        }

        // 根据选中的省、市、区执行天气查询
        private WeatherDetail Search(PlaceModel province, PlaceModel city, PlaceModel district)
        {
            WeatherDetail detail = new WeatherDetail(province, city, district); // 创建天气详情对象
            detail.HandleWeather(); // 处理天气数据
            return detail; // 返回天气详情
        }

        // 关于按钮点击事件处理，显示关于信息
        private void buttonAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"天气预报\r\n版本：{Assembly.GetExecutingAssembly().GetName().Version.ToString()}\r\n我们是行迹精灵\r\n欢迎使用行迹精灵的天气查询功能，安排您的完美出行", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // XML路径，用于保存区域数据
        string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "weather.xml");
        AreaCollection areas; // 区域集合

        // 绑定菜单，提供添加和删除城市的功能
        private void BindMenu()
        {
            buttonCustom.DropDownItems.Clear(); // 清空自定义按钮的下拉项
            // 反序列化XML数据到区域集合
            areas = XmlOperator.Deserialize<AreaCollection>(path);
            if (areas != null)
            {
                for (int i = 0; i < areas.Areas.Length; i++)
                {
                    ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem
                    {
                        Name = $"toolStripMenuItem_{areas.Areas[i].Province.Name}_{areas.Areas[i].City.Name}_{areas.Areas[i].District.Name}",
                        Text = areas.Areas[i].Name,
                        Tag = areas.Areas[i]
                    };
                    // 为每个已保存的区域添加点击事件处理
                    toolStripMenuItem.Click += (s, o) =>
                    {
                        ToolStripMenuItem _toolStripMenuItem = (ToolStripMenuItem)s;
                        Area area = (Area)_toolStripMenuItem.Tag;
                        // 设置选中项并执行搜索
                        comboBoxProvince.SelectedItem = area.Province;
                        comboBoxCity.SelectedItem = area.City;
                        comboBoxDistrict.SelectedItem = area.District;
                        buttonSearch.PerformClick();
                    };
                    buttonCustom.DropDownItems.Add(toolStripMenuItem); // 添加菜单项
                }
            }
            else
            {
                areas = new AreaCollection(); // 创建新的区域集合
            }
            buttonCustom.DropDownItems.Add(new ToolStripSeparator()); // 添加分隔符
            ToolStripMenuItem toolStripMenuItem1 = new ToolStripMenuItem()
            {
                Name = "toolStripMenuItem_AddCity",
                Text = "添加城市",
            };
            // 添加城市菜单项的点击事件处理
            toolStripMenuItem1.Click += (s, o) =>
            {
                // 获取选中的省、市、区
                PlaceModel province = comboBoxProvince.ComboBox.SelectedItem as PlaceModel;
                PlaceModel city = comboBoxCity.ComboBox.SelectedItem as PlaceModel;
                PlaceModel district = comboBoxDistrict.ComboBox.SelectedItem as PlaceModel;
                if (province != null && city != null && district != null)
                {
                    // 添加新区域到集合并保存到XML
                    areas.Add(new Area() { Name = district.Name, Province = province, City = city, District = district });
                    XmlOperator.Serialize(path, areas);
                    BindMenu(); // 重新绑定菜单
                }
            };
            buttonCustom.DropDownItems.Add(toolStripMenuItem1); // 添加菜单项

            ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem()
            {
                Name = "toolStripMenuItem_DeleteCity",
                Text = "删除城市",
            };
            // 删除城市菜单项的点击事件处理
            toolStripMenuItem2.Click += (s, o) =>
            {
                // 获取选中的省、市、区
                PlaceModel province = comboBoxProvince.ComboBox.SelectedItem as PlaceModel;
                PlaceModel city = comboBoxCity.ComboBox.SelectedItem as PlaceModel;
                PlaceModel district = comboBoxDistrict.ComboBox.SelectedItem as PlaceModel;
                if (province != null && city != null && district != null)
                {
                    // 从集合中删除区域并保存到XML
                    areas.Remove(new Area() { Name = district.Name, Province = province, City = city, District = district });
                    XmlOperator.Serialize(path, areas);
                    BindMenu(); // 重新绑定菜单
                }
            };
            buttonCustom.DropDownItems.Add(toolStripMenuItem2); // 添加菜单项
        }

        private void Travel_Weather_Load(object sender, EventArgs e)
        {
            // 设置版本标签文本
            //lblVerson.Text = $"版本：{Assembly.GetExecutingAssembly().GetName().Version.ToString()}";
            // 设置状态标签文本
            //lblStatus.Text = "数据加载中";
            // 绑定菜单
            BindMenu();

            // 在后台任务中加载省市区数据并获取当前位置
            Task.Factory.StartNew(() =>
            {
                BindProvince(); // 绑定省份
                BindCity(); // 绑定城市
                BindDistrict(); // 绑定地区

                // 获取本机IP地址
                string ipAddress = GetLocalIPAddress();
                // 获取地理位置
                var location = GetLocationByIP(ipAddress);

                this.BeginInvokeToForm(() =>
                {
                    if (location != default)
                    {
                        // 确保数据源已正确绑定
                        var provinces = comboBoxProvince.ComboBox.DataSource as PlaceModel[];
                        var cities = comboBoxCity.ComboBox.DataSource as PlaceModel[];
                        var districts = comboBoxDistrict.ComboBox.DataSource as PlaceModel[];

                        // 设置默认选择项
                        comboBoxProvince.ComboBox.SelectedValue = location.Province;
                        BindCity(); // 绑定城市数据
                        comboBoxCity.ComboBox.SelectedValue = location.City;
                        BindDistrict(); // 绑定地区数据
                        comboBoxDistrict.ComboBox.SelectedValue = location.District;
                    }
                    else if (areas != null && areas.Areas != null && areas.Areas.Length > 0)
                    {
                        comboBoxProvince.ComboBox.SelectedValue = areas.Areas[0].Province.ID;
                        BindCity(); // 绑定城市数据
                        comboBoxCity.ComboBox.SelectedValue = areas.Areas[0].City.ID;
                        BindDistrict(); // 绑定地区数据
                        comboBoxDistrict.ComboBox.SelectedValue = areas.Areas[0].District.ID;
                    }
                    buttonSearch.PerformClick(); // 执行搜索
                });
            }).ContinueWith(t =>
            {
                // 如果任务出现故障，更新状态标签
                if (t.IsFaulted)
                {
                    //this.InvokeToForm(() => lblStatus.Text = "地区加载错误，请确保联网正确");
                }
            });
        }

        private string GetLocalIPAddress()
        {
            using (WebClient client = new WebClient())
            {
                // 调用外部服务获取本机IP地址
                return client.DownloadString("https://api.ipify.org");
            }
        }

        private (string Province, string City, string District) GetLocationByIP(string ipAddress)
        {
            using (WebClient client = new WebClient())
            {
                // 调用外部服务根据IP地址获取地理位置
                string response = client.DownloadString($"https://ipapi.co/{ipAddress}/json/");
                dynamic jsonResponse = JsonConvert.DeserializeObject(response);

                if (jsonResponse != null)
                {
                    return (jsonResponse.region, jsonResponse.city, jsonResponse.district);
                }
                return (null, null, null);
            }
        }
    }
}
