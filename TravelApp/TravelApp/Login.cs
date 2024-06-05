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
            
            long passwordEncrypt=SimpleEncryptionHelper.EncryptLong(long.Parse(password));

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
                       // string url = baseUrl + "/login?Uid=" + userID + "&password=" + passwordMD5;
                        string url = baseUrl + "/?id=" + userID + "&pwd=" + passwordEncrypt;
                        Client client = new Client();
                        HttpResponseMessage result = await client.Get(url);
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
                            // MessageBox.Show("用户名或密码输入错误");
                            string errorMessage = await result.Content.ReadAsStringAsync();
                            MessageBox.Show($"Failed . Error: {errorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public static class SimpleEncryptionHelper
        {
            private static readonly long key = 0x2A3B4C5D6E7F8090; // Replace with your key

            public static long EncryptLong(long value)
            {
                return value ^ key;
            }

            public static long DecryptLong(long encryptedValue)
            {
                return encryptedValue ^ key;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';   //显示输入
            }
            else
            {
                textBox2.PasswordChar = '*';   //显示*
            }
        }
    }
}
