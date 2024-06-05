using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace TravelApp
{
    [System.Runtime.InteropServices.ComVisible(true)]
    public partial class Walk_Routing : Form
    {
        public Walk_Routing()
        {
            InitializeComponent();
           
        }

        private void Walk_Routing_Load(object sender, EventArgs e)
        {
            string str_url = Application.StartupPath + "\\Bike_Map.html";
            webBrowser_walk.Navigate(new Uri(str_url));
            webBrowser_walk.ObjectForScripting = this;
            pictureBox1.BackColor = Color.Transparent;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void webBrowser_walk_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
