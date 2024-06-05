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
            label1.BackColor = Color.Transparent;  //将标签的背景设置为透明
            button1.BackColor = Color.Transparent;  //将标签的背景设置为透明
            button2.BackColor = Color.Transparent;  //将标签的背景设置为透明
            button3.BackColor = Color.Transparent;  //将标签的背景设置为透明
            button4.BackColor = Color.Transparent;  //将标签的背景设置为透明
            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox5.BackColor = Color.Transparent;

        }
        private void CloseOtherForms()
        {
            // 获取当前打开的所有窗体
            Form[] openForms = Application.OpenForms.Cast<Form>().ToArray();
            foreach (Form form in openForms)
            {
                // 关闭除主窗体以外的其他窗体
                if (form.Name != "MainFormFinal"&&form.Name!="Navigation")
                {
                    form.Close();
                }
                //MessageBox.Show(form.Name);
            }
        }
        //打开导航子窗体
        private void openBusPage()
        {
            //CloseOtherForms();//先关闭除主窗体以外的其他窗体，即关闭所有子窗体
            Bus_Routing bus = new Bus_Routing();//实例化frmHome子窗体
            bus.Dock = System.Windows.Forms.DockStyle.Fill;//设置Dock为Fill使子窗体占满splitContainer1.Panel2
            bus.TopLevel = false;//设置为非顶级控件，否则无法添加
            bus.Show();//使窗体显示
            panel_navi.Controls.Clear();//清除splitContainer1.Panel2内容
            panel_navi.Controls.Add(bus);//将frmHome添加到splitContainer1.Panel2中
        }
        private void openCarPage()
        {
           // CloseOtherForms();//先关闭除主窗体以外的其他窗体，即关闭所有子窗体
            Car_Routing car = new Car_Routing();//实例化frmHome子窗体
            car.Dock = System.Windows.Forms.DockStyle.Fill;//设置Dock为Fill使子窗体占满splitContainer1.Panel2
            car.TopLevel = false;//设置为非顶级控件，否则无法添加
            car.Show();//使窗体显示
            panel_navi.Controls.Clear();//清除splitContainer1.Panel2内容
            panel_navi.Controls.Add(car);//将frmHome添加到splitContainer1.Panel2中
        }

        private void openBikePage()
        {
           // CloseOtherForms();//先关闭除主窗体以外的其他窗体，即关闭所有子窗体
            Bike_Routing bike = new Bike_Routing();//实例化frmHome子窗体
            bike.Dock = System.Windows.Forms.DockStyle.Fill;//设置Dock为Fill使子窗体占满splitContainer1.Panel2
            bike.TopLevel = false;//设置为非顶级控件，否则无法添加
            bike.Show();//使窗体显示
            panel_navi.Controls.Clear();//清除splitContainer1.Panel2内容
            panel_navi.Controls.Add(bike);//将frmHome添加到splitContainer1.Panel2中
        }
        private void openWalkPage()
        {
           // CloseOtherForms();//先关闭除主窗体以外的其他窗体，即关闭所有子窗体
            Walk_Routing walk = new Walk_Routing();//实例化frmHome子窗体
            walk.Dock = System.Windows.Forms.DockStyle.Fill;//设置Dock为Fill使子窗体占满splitContainer1.Panel2
            walk.TopLevel = false;//设置为非顶级控件，否则无法添加
            walk.Show();//使窗体显示
            panel_navi.Controls.Clear();//清除splitContainer1.Panel2内容
            panel_navi.Controls.Add(walk);//将frmHome添加到splitContainer1.Panel2中
        }
        // 打开新的WinForm界面


        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openCarPage();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openWalkPage();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            openBikePage();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            openBusPage();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
