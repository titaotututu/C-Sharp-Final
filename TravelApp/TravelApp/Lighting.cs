using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;       //添加类对COM可见-ComVisibleAttribute(true)/ 
using System.IO;
using System.Threading;
using System.Collections;
using Newtonsoft.Json;
using System.Net.Http;
using TravelApp.models;


namespace TravelApp
{
    [System.Runtime.InteropServices.ComVisible(true)]
    public partial class Lighting : Form
    {
        public long Uid {  get; set; }
        public Lighting(long uid)
        {
            InitializeComponent();
            Uid = uid;
        }
        private void Lighting_Load(object sender, EventArgs e)
        {
            // 导航到HTML页面
            string path = System.IO.Path.Combine(Application.StartupPath, "lighting.html");
            webBrowser_light.Navigate(path);

            // 设置WebBrowser控件的DocumentCompleted事件
            webBrowser_light.DocumentCompleted += webBrowser_light_DocumentCompleted;
            // 初始化信息
            InitInfo();
        }

        private void button_light_Click(object sender, EventArgs e)
        {
            // 获取TextBox中的城市名称
            string cities = textBox_city.Text;

            // 设置HTML页面中的输入框值
            HtmlElement districtInput = webBrowser_light.Document.GetElementById("district");
            if (districtInput != null)
            {
                districtInput.SetAttribute("value", cities);
            }

            // 点击HTML页面中的按钮
            HtmlElement drawButton = webBrowser_light.Document.GetElementById("draw");
            if (drawButton != null)
            {
                drawButton.InvokeMember("click");
            }
        }

        private void webBrowser_light_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            // 在HTML加载完成后，将WinForms窗体实例传递给JavaScript，以便调用其方法
            webBrowser_light.ObjectForScripting = this;
        }

        // 修改为读取uid对应的travel的city，有就点亮
        private async void InitInfo()
        {
            long id = Uid;
            string url = "http://localhost:5199/api/Travel/get?uid=" + id;
            HttpClient client = new HttpClient();
            try
            {
                // 发送 GET 请求获取行程信息
                HttpResponseMessage result = await client.GetAsync(url);
                if (result.IsSuccessStatusCode)
                {
                    string jsonContent = await result.Content.ReadAsStringAsync();
                    List<Travel> travels = JsonConvert.DeserializeObject<List<Travel>>(jsonContent);

                    // 提取城市名称
                    HashSet<string> cityNames = new HashSet<string>();
                    foreach (Travel travel in travels)
                    {
                        cityNames.Add(travel.TravelCity);
                    }

                    // 将所有城市转化为“城市1，城市2，城市3”的格式
                    string cities = string.Join(",", cityNames);

                    // 设置TextBox的值
                    textBox_city.Text = cities;

                    // 调用button_light_Click方法
                    button_light_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }




    }
}
