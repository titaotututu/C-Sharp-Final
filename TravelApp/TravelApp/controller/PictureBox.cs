using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelApp.controller
{
    public partial class PictureBox : UserControl
    {
        public string FileName;
        public long JournalId;
        public Refresh Refresh;
        //待补充
        private readonly string baseUrl = "http://localhost:5199/api/File/delete?journalId={0}&fileName={1}";
        public PictureBox(long journalId, string fileName, Refresh refresh)
        {
            InitializeComponent();
            JournalId = journalId;
            FileName = fileName;
            Refresh = refresh;
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            try
            {
                string url = string.Format(baseUrl, this.JournalId, this.FileName);
                FileClient fileClient = new FileClient();
                fileClient.Delete(url);
                this.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
