using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using TravelApp.models;
using Newtonsoft.Json;


namespace TravelApp.controller
{
    public partial class OldTravel : UserControl
    {
        long Uid;
        // 显示有点问题
        public OldTravel(long uid)
        {
            InitializeComponent();
            Uid = uid;
            InitInfo();
            

        }

        public async void InitInfo()
        {   // long id =this.uid;// 多个部分需要注意加上uid
            //long id = 123;
            long id=Uid;
            string url = "http://localhost:5199/api/Travel/get?uid=" + id;
            Client client = new Client();
            try
            {
                // 发送 GET 请求获取行程信息
                HttpResponseMessage result = await client.Get(url);
                if (result.IsSuccessStatusCode)
                {
                    string jsonContent = await result.Content.ReadAsStringAsync();
                    List<Travel> travels = JsonConvert.DeserializeObject<List<Travel>>(jsonContent);

                    // 清空控件容器
                    panelHistoryTravel.Controls.Clear();

                    // 遍历行程列表
                    foreach (Travel travel in travels)
                    {
                        // 添加到panel中

                        HistoryPage his = new HistoryPage(travel);
                        // 订阅 TravelDeleted 事件
                        his.TravelDeleted += His_TravelDeleted;
                        panelHistoryTravel.Controls.Add(his);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InitInfo();
        }

        private void His_TravelDeleted(object sender, EventArgs e)
        {
            // 重新初始化信息
            panelHistoryTravel.Controls.Clear();
            InitInfo();
        }
    }
}
