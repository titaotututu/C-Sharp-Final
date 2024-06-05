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


namespace TravelApp
{
    [System.Runtime.InteropServices.ComVisible(true)]
    public partial class Car_Routing : Form  //驾车形成规划
    {
        public Car_Routing()
        {
            InitializeComponent();
            
        }

        private void Car_Routing_Load(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Transparent;
            string str_url = Application.StartupPath + "\\Car_Map.html";
            webBrowser_car.Navigate(new Uri(str_url));
            webBrowser_car.ObjectForScripting = this;
            
        }

        private void webBrowser_car_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
