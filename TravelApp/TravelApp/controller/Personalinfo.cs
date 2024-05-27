using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelApp.models;

namespace TravelApp.controller
{
    public partial class Personalinfo : UserControl
    {
        private readonly string baseUrl = "http://localhost:5199/api/User";
        private readonly long Uid;
        public Personalinfo(long uid)
        {
            InitializeComponent();
            this.Uid = uid;
            InitInfo();
        }

        private async void InitInfo()
        {
            //初始化相关信息
            string url = baseUrl + "/get?uid=" + this.Uid;
            //
            //XmlSerializer xmlSerializer = new XmlSerializer(typeof(User));
            //
            User user = new User();
            Client client = new Client();
            try
            {
                HttpResponseMessage result = await client.Get(url);
                if (result.IsSuccessStatusCode)
                {
                    //
                    //User user = (User)xmlSerializer.Deserialize(await result.Content.ReadAsStreamAsync());
                    //
                    new_id.Text = user.Uid.ToString("00000");
                    new_name.Text = user.Uname;
                    //cbGender.Text = user.Sex;
                    new_pwd.Text = Convert.ToString(user.Password);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            //进行代码提交
            string id = new_id.Text;
            string url = baseUrl + "/update?uid=" + id;
            //
            //XmlSerializer xmlSerializer = new XmlSerializer(typeof(User));
            //
            User user = new User();
            Client client = new Client();
            try
            {
                //string data = "";
                HttpResponseMessage result = await client.Get(baseUrl + "/get?uid=" + id);
                if (result.IsSuccessStatusCode)
                {
                    //
                    //User user = (User)xmlSerializer.Deserialize(await result.Content.ReadAsStreamAsync());
                    //
                    user.Uname = new_name.Text;
                    //user.Sex = cbGender.Text;
                    user.Password = long.Parse(new_pwd.Text);

                    //
                    //using (StringWriter sw = new StringWriter())
                    //{
                    //    xmlSerializer.Serialize(sw, user);
                    //    data = sw.ToString();
                    //}
                    //
                    string data = JsonConvert.SerializeObject(user);
                    result = await client.Put(url, data);
                    if (result.IsSuccessStatusCode)
                    {
                        MessageBox.Show("修改成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
