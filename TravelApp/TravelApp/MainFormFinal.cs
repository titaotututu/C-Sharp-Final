using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelApp.controller;
using Weather_space;

namespace TravelApp
{
    public delegate void ChangePanel(Control c);
    public partial class MainFormFinal : Form
    {
        private Point formPoint = new Point();
        public ChangePanel changePanel;
        public long Uid;
        public MainFormFinal(long Uid)// 应该传入一个uid参数
        {
            InitializeComponent();
            this.Uid = Uid;
        }

        public void AddControlsToPanel(Control c)
        {
            
            c.Dock = DockStyle.Fill;
            panelControl.Controls.Clear();
            panelControl.Controls.Add(c);
        }

        private void button_Weather_Click(object sender, EventArgs e)
        {
            Travel_Weather travel_weather= new Travel_Weather(changePanel);
            AddControlsToPanel(travel_weather);
        }

        private void button_Travel_Click(object sender, EventArgs e)
        {
            MyTravel mytravel = new MyTravel(changePanel,Uid);
            AddControlsToPanel(mytravel);
        }
       
        private void MainFormFianl_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox5.BackColor = Color.Transparent;
            pictureBox6.BackColor = Color.Transparent;
            pictureBox7.BackColor = Color.Transparent;
        }

        //关闭除了主窗体以外的其他窗体
        private void CloseOtherForms()
        {
            // 获取当前打开的所有窗体
            Form[] openForms = Application.OpenForms.Cast<Form>().ToArray();
            foreach (Form form in openForms)
            {
                // 关闭除主窗体以外的其他窗体
                if (form.Name != "MainFormFinal")
                {
                    form.Close();
                }
                //MessageBox.Show(form.Name);
            }
        }
        //打开导航子窗体
        private void openNavigationPage()
        {
            //CloseOtherForms();//先关闭除主窗体以外的其他窗体，即关闭所有子窗体
            Navigation navi = new Navigation();//实例化frmHome子窗体
            navi.Dock = System.Windows.Forms.DockStyle.Fill;//设置Dock为Fill使子窗体占满splitContainer1.Panel2
            navi.TopLevel = false;//设置为非顶级控件，否则无法添加
            navi.Show();//使窗体显示
            panelControl.Controls.Clear();//清除splitContainer1.Panel2内容
            panelControl.Controls.Add(navi);//将frmHome添加到splitContainer1.Panel2中
        }
        //点亮城市主窗体
        private void openLightingPage()
        {
            //CloseOtherForms();//先关闭除主窗体以外的其他窗体，即关闭所有子窗体
            Lighting light = new Lighting(Uid);//实例化frmHome子窗体
            light.Dock = System.Windows.Forms.DockStyle.Fill;//设置Dock为Fill使子窗体占满splitContainer1.Panel2
            light.TopLevel = false;//设置为非顶级控件，否则无法添加
            light.Show();//使窗体显示
            panelControl.Controls.Clear();//清除splitContainer1.Panel2内容
            panelControl.Controls.Add(light);//将frmHome添加到splitContainer1.Panel2中
        }
        private void openElsePage()
        {
           // CloseOtherForms();//先关闭除主窗体以外的其他窗体，即关闭所有子窗体
            Else el = new Else();//实例化frmHome子窗体
            el.Dock = System.Windows.Forms.DockStyle.Fill;//设置Dock为Fill使子窗体占满splitContainer1.Panel2
            el.TopLevel = false;//设置为非顶级控件，否则无法添加
            el.Show();//使窗体显示
            panelControl.Controls.Clear();//清除splitContainer1.Panel2内容
            panelControl.Controls.Add(el);//将frmHome添加到splitContainer1.Panel2中
        }
        private void button_UserInfo_Click(object sender, EventArgs e)
        {
            Personalinfo p = new Personalinfo(Uid,changePanel);
            AddControlsToPanel(p);
        }

        private void button_Navigation_Click(object sender, EventArgs e)
        {
            openNavigationPage();
        }

        private void button_Lighting_Click(object sender, EventArgs e)
        {
            openLightingPage();
        }

        private void button_Other_Click(object sender, EventArgs e)
        {
            openElsePage();
        }

        private void button_Journal_Click(object sender, EventArgs e)
        {
            JournalList journalList = new JournalList(Uid, changePanel);
            AddControlsToPanel(journalList);
        }
    }
}
