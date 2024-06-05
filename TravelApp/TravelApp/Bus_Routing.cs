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
    public partial class Bus_Routing : Form
    {
        public Bus_Routing()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void Bus_Routing_Load(object sender, EventArgs e)
        {
            string str_url = Application.StartupPath + "\\Bus_Map.html";
            webBrowser_bus.Navigate(new Uri(str_url));
            webBrowser_bus.ObjectForScripting = this;
            pictureBox1.BackColor=Color.Transparent;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           this.Close ();
        }
    }
}
