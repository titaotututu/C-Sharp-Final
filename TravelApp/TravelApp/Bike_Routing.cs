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
    public partial class Biking_Routing : Form
    {
        public Biking_Routing()
        {
            InitializeComponent();
        }

        private void Biking_Routing_Load(object sender, EventArgs e)
        {
            string str_url = Application.StartupPath + "\\Bike_Map.html";
            webBrowser_bike.Navigate(new Uri(str_url));
            webBrowser_bike.ObjectForScripting = this;

        }
    }
}
