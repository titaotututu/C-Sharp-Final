using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using TravelApp.models;

namespace TravelApp.controller
{
    public delegate void Refresh();
    public partial class JournalList : UserControl
    {
        public long UserId;
        public ChangePanel ChangePanel;
        public JournalList(long userId, ChangePanel changePanel)
        {
            InitializeComponent();
            this.UserId = userId;
            this.ChangePanel = changePanel;
            Init();
        }
        public async void Init()
        {
            long uid = this.UserId;
            string url = "http://localhost:5199/api/Journal/getByUser?userId=" + uid;

            Client client = new Client();
            try
            {
                HttpResponseMessage result = await client.Get(url);
                if (result.IsSuccessStatusCode)
                {
                    string jsonContent = await result.Content.ReadAsStringAsync();
                    List<Journal> journals = JsonConvert.DeserializeObject<List<Journal>>(jsonContent);

                    flpJournalList.Controls.Clear();

                    foreach (Journal journal in journals)
                    {
                        JournalCell cell = new JournalCell(journal.JournalId, this.ChangePanel, this.Init);
                        cell.lblTitle.Text = journal.Title;
                        cell.lblWeather.Text = journal.Weather;
                        cell.lblTime.Text = journal.Time.ToString();
                        //添加到panel中
                        flpJournalList.Controls.Add(cell);
                    }
                    //添加底部标志
                    Label lblBottom = new Label();
                    lblBottom.Text = "无更多内容";
                    lblBottom.Anchor = AnchorStyles.None;
                    flpJournalList.Controls.Add(lblBottom);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void pbAdd_Click(object sender, EventArgs e)
        {
            string url = "http://localhost:5199/api/Journal";

            Journal journal = new Journal();

            //初始化
            journal.JournalId = 0;
            journal.Time = DateTime.Now;
            journal.Title = "";
            journal.Weather = "";
            journal.Emotion = "";
            journal.Description = "";
            journal.Picture = "";
            journal.UserId = this.UserId;

            Client client = new Client();
            try
            {
                string data = JsonConvert.SerializeObject(journal);
                Console.WriteLine("Sending data: " + data); // 打印出发送的数据

                HttpResponseMessage result = await client.Post(url, data);
                if (result.IsSuccessStatusCode)
                {
                    string jsonContent = await result.Content.ReadAsStringAsync();
                    journal = JsonConvert.DeserializeObject<Journal>(jsonContent);
                }
                else
                {
                    string responseContent = await result.Content.ReadAsStringAsync();
                    MessageBox.Show("无法创建日志对象: " + result.ReasonPhrase, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //跳转至编辑日志界面
            JournalDetail journalDetail = new JournalDetail(journal, this.ChangePanel);
            panelControl.Controls.Clear();
            panelControl.BringToFront();
            panelControl.Controls.Add(journalDetail);
        }
    }
}
