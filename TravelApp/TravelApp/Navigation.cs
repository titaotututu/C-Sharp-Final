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
    public partial class Navigation : Form
    {
        public Navigation()
        {
            InitializeComponent();
        }

        private void Navigation_Load(object sender, EventArgs e)
        {
            // 导航到HTML页面
            string path = System.IO.Path.Combine(Application.StartupPath, "Navigator.html");
            webBrowser_navi.Navigate(path);

            // 设置WebBrowser控件的DocumentCompleted事件
            webBrowser_navi.DocumentCompleted += WebBrowser1_DocumentCompleted;
        }
        private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            // 在HTML加载完成后，将WinForms窗体实例传递给JavaScript，以便调用其方法
            webBrowser_navi.ObjectForScripting = this;
        }

        // 以下是用于JavaScript调用的方法
        public void NavigateTo(string formName)
        {
            switch (formName)
            {
                case "DrivingRouteForm":
                    OpenForm(new Car_Routing());
                    break;
                case "BikingRouteForm":
                    OpenForm(new Bike_Routing());
                    break;
                case "WalkingRouteForm":
                    OpenForm(new Walk_Routing());
                    break;
                case "TransitRouteForm":
                    OpenForm(new Bus_Routing());
                    break;
                default:
                    MessageBox.Show("Invalid form name.");
                    break;
            }
        }

        // 打开新的WinForm界面
        private void OpenForm(Form form)
        {
            form.Show();
        }
    }
}
