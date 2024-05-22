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
    public partial class Walk_Routing : Form
    {
        public Walk_Routing()
        {
            InitializeComponent();
        }

        private void Walk_Routing_Load(object sender, EventArgs e)
        {
            string str_url = Application.StartupPath + "\\Walk_Map.html";
            webBrowser_walk.Navigate(new Uri(str_url));
            webBrowser_walk.ObjectForScripting = this;
        }
    }
}
