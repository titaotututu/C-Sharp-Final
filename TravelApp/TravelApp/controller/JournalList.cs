using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        private readonly long UserId;
        private readonly ChangePanel ChangePanel;
        public JournalList(long userId, ChangePanel changePanel)
        {
            InitializeComponent();
            UserId = userId;
            ChangePanel = changePanel;
            Init();
        }
        private async void Init()
        {
            long id = this.UserId;
            string url = "https://localhost:7119/api/User/" + id;
           // XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Journal>));
            Client client = new Client();
            try
            {
                HttpResponseMessage result = await client.Get(url);
                if (result.IsSuccessStatusCode)
                {
                    List<Journal> journals = new List<Journal>();//(List<Journal>)xmlSerializer.Deserialize(await result.Content.ReadAsStreamAsync());
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
                    lblBottom.Text = "没有更多内容";
                    lblBottom.Anchor = AnchorStyles.None;
                    flpJournalList.Controls.Add(lblBottom);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
