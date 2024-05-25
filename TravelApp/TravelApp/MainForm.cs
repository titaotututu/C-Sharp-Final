using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace TravelApp
{
    public partial class MainForm : MaterialForm
    {
        private MaterialSkinManager materialSkinManager;
        public MainForm()
        {
            InitializeComponent();
            InitializeMaterialSkinManager();
        }

        private void InitializeMaterialSkinManager()
        {
            // 创建MaterialSkinManager实例
            materialSkinManager = MaterialSkinManager.Instance;

            // 将当前窗体添加到MaterialSkinManager管理
            materialSkinManager.AddFormToManage(this);

            // 设置主题
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // 设置颜色方案
            materialSkinManager.ColorScheme = new ColorScheme(
                        Primary.Green600,
                        Primary.Green700,
                        Primary.Green200,
                        Accent.Red100,
                        TextShade.WHITE);
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
