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
        private readonly string FileName;
        private readonly long JournalId;
        private Refresh Refresh;
        //待补充
        private readonly string baseUrl = "????";
        public PictureBox(long journalId, string fileName, Refresh refresh)
        {
            InitializeComponent();
            JournalId = journalId;
            FileName = fileName;
            Refresh = refresh;
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            string url = string.Format(baseUrl, this.JournalId, this.FileName);
            FileClient fileClient = new FileClient();
            fileClient.Delete(url);
            this.Refresh();
        }
    }
}
