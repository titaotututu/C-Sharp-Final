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
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using TravelApp.models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace TravelApp.controller
{
    public partial class AddTodo : UserControl
    {
        long TravelId;
        public AddTodo(long travelid)
        {
            this.TravelId = travelid;
            InitializeComponent();
        }

        private async void buttonOk_Click(object sender, EventArgs e)
        {
            TodoItem todo=new TodoItem();
            

            string url = "http://localhost:5199/api/TodoItem";
            
            Client client = new Client();

            try
            {
                todo.TravelId = this.TravelId;
                todo.Time = DateTime.Parse(textBoxTime.Text);
                todo.Place = textBoxPlace.Text;
                todo.Description=textBoxThing.Text;
                todo.IsCompleted = false;
                string jsonData = JsonConvert.SerializeObject(todo);
                HttpResponseMessage result = await client.Post(url, jsonData);
                if (result.IsSuccessStatusCode)
                {
                    MessageBox.Show("创建成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string errorMessage = await result.Content.ReadAsStringAsync();
                    MessageBox.Show($"创建失败：{errorMessage}", "失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


    }
    
}
