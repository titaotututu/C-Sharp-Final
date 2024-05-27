using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Net.Http;
using TravelApp.models;
using System.Security.Cryptography;
using Newtonsoft.Json;


namespace TravelApp
{
    public partial class Register : Form
    {
        private string baseUrl = "http://localhost:5199/api/User";
        public Register()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (reg_name.Text.Length == 0 || reg_name.Text == "单行输入")
            {
                MessageBox.Show("请输入用户姓名");
            }

            else
               if (reg_pwd.Text.Length == 0 || reg_pwd.Text == "单行输入")
            {
                MessageBox.Show("请输入密码");
            }
            else
            {
                User user = new User();
                //
                //XmlSerializer xmlSerializer = new XmlSerializer(typeof(User));
                //
                Client client = new Client();
                //string data = "";

                try
                {
                    string url = baseUrl ;
                    user.Uname = reg_name.Text;
                    // 先不用加密
                   // user.Password = long.Parse(MD5Encrypt(reg_pwd.Text));
                   user.Password=long.Parse(reg_pwd.Text);
                    //
                    //using (StringWriter sw = new StringWriter())
                    //{
                    //    xmlSerializer.Serialize(sw, user);
                    //    data = sw.ToString();
                    //}
                    //
                    string data = JsonConvert.SerializeObject(user);
                    Console.WriteLine(data);    
                    HttpResponseMessage result = await client.Post(url, data);
                    if (result.IsSuccessStatusCode)
                    {
                        User newuser = new User();
                        //
                        //newuser = (User)xmlSerializer.Deserialize(await result.Content.ReadAsStreamAsync());
                        //
                        user.Uid = long.Parse(newuser.Uid.ToString("00000"));
                        MessageBox.Show("注册成功!您的ID是" + newuser.Uid.ToString("00000"));
                        using (MainFormFinal mff = new MainFormFinal(newuser.Uid))
                        {
                            this.Hide();
                            mff.ShowDialog();
                            this.Dispose();
                        }
                    }
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message);
                }

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
