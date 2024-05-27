using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.IO;
using System.Net.Http;
using System.Security.Cryptography;
using Microsoft.Win32;

namespace TravelApp
{
    public partial class Login : Form
    {
        private string baseUrl = "http://localhost:5199/api/User";
        public Login()
        {
            InitializeComponent();
        }

        //登录
        private async void button3_Click(object sender, EventArgs e)
        {
            string userID = textBox1.Text;
            string password = textBox2.Text;
            string passwordMD5 = MD5Encrypt(password);

            if (userID.Length == 0 || userID == "单行输入")
            {
                MessageBox.Show("用户ID为空");
            }
            else
            {
                if (password.Length == 0 || password == "单行输入")
                {
                    MessageBox.Show("密码为空");
                }
                else
                {
                    try
                    {
                        string url = baseUrl + "/login?Uid=" + userID + "&password=" + passwordMD5;
                        Client client = new Client();
                        HttpResponseMessage result = await client.Put(url, "");
                        if (result.IsSuccessStatusCode)
                        {

                            using (MainFormFinal mff = new MainFormFinal(long.Parse(userID)))
                            {
                                mff.changePanel = mff.AddControlsToPanel;
                                this.Hide();
                                mff.ShowDialog();
                                textBox1.Text = "";
                                textBox2.Text = "";
                            }
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show("用户名或密码输入错误");
                        }
                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show(e1.Message);
                    }
                }
            }
        }

        //跳转到注册
        private void button4_Click(object sender, EventArgs e)
        {
            using (Register reg = new Register())
            {
                this.Hide();
                reg.ShowDialog();
                this.Show();
            }
        }

        public static string MD5Encrypt(string strText)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] targetData = md5.ComputeHash(Encoding.UTF8.GetBytes(strText));

            string byte2String = null;

            for (int i = 0; i < targetData.Length; i++)
            {
                byte2String += targetData[i].ToString("x2");
            }

            return byte2String.ToUpper();
        }
    }
}
