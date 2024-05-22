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
    public partial class Lighting : Form
    {
        public Lighting()
        {
            InitializeComponent();
        }
        private void Lighting_Load(object sender, EventArgs e)
        {
            // 导航到HTML页面
            string path = System.IO.Path.Combine(Application.StartupPath, "lighting.html");
            webBrowser_light.Navigate(path);

            // 设置WebBrowser控件的DocumentCompleted事件
            webBrowser_light.DocumentCompleted += webBrowser_light_DocumentCompleted;
        }

        private void button_light_Click(object sender, EventArgs e)
        {
            // 获取TextBox中的城市名称
            string cities = textBox_city.Text;

            // 设置HTML页面中的输入框值
            HtmlElement districtInput = webBrowser_light.Document.GetElementById("district");
            if (districtInput != null)
            {
                districtInput.SetAttribute("value", cities);
            }

            // 点击HTML页面中的按钮
            HtmlElement drawButton = webBrowser_light.Document.GetElementById("draw");
            if (drawButton != null)
            {
                drawButton.InvokeMember("click");
            }
        }

        private void webBrowser_light_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            // 在HTML加载完成后，将WinForms窗体实例传递给JavaScript，以便调用其方法
            webBrowser_light.ObjectForScripting = this;
        }

        
    }
}
