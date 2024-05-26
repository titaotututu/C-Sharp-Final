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
        private readonly long JournalId;
        private readonly ChangePanel ChangePanel;
        public Refresh Refresh;
        public JournalCell(long journalId, ChangePanel changePanel, Refresh refresh)
        {
            InitializeComponent();
            JournalId = journalId;
            ChangePanel = changePanel;
            Refresh = refresh;
        }

        private void JournalCell_Click(object sender, EventArgs e)
        {
            long id = this.JournalId;
            JournalDetail journalDetail = new JournalDetail(id, this.ChangePanel);
            this.ChangePanel(journalDetail);
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
    }
}
