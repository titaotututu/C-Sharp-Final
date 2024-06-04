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

namespace TravelApp.controller
{
    public partial class JournalCell : UserControl
    {
        public long JournalId;
        public Refresh Refresh;
        public ChangePanel ChangePanel;
        public JournalCell(long journalId, ChangePanel changePanel, Refresh refresh)
        {
            InitializeComponent();
            this.JournalId = journalId;
            this.ChangePanel = changePanel;
            this.Refresh = refresh;
        }

        private async void pbDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("是否确认删除此日志？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.OK)
            {
                long id = this.JournalId;
                string url = "http://localhost:5199/api/Journal/delete?journalid=" + id;
                Client client = new Client();
                try
                {
                    HttpResponseMessage result = await client.Delete(url);
                    if (!result.IsSuccessStatusCode)
                    {
                        MessageBox.Show("删除未成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    this.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n删除失败", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void JournalCell_Click(object sender, EventArgs e)
        {
            long id = this.JournalId;
            JournalDetail journalDetail = new JournalDetail(id, ChangePanel);
            this.ChangePanel(journalDetail);
        }

        private void pictureBoxGoose_Click(object sender, EventArgs e)
        {
            JournalCell_Click(sender, e);
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
            JournalCell_Click(sender, e);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            JournalCell_Click(sender, e);
        }

        private void lblWeather_Click(object sender, EventArgs e)
        {
            JournalCell_Click(sender, e);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            JournalCell_Click(sender, e);
        }

        private void lblTime_Click(object sender, EventArgs e)
        {
            JournalCell_Click(sender, e);
        }
    }
}
