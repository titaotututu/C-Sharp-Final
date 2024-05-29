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
        public event EventHandler TodoAdded;
        long TravelId;
        DateTime TravelTime;
        public AddTodo(long travelid, DateTime travelTime)
        {
            this.TravelId = travelid;
            this.TravelTime = travelTime;
            InitializeComponent();
            
        }

        private async void buttonOk_Click(object sender, EventArgs e)
        {
            TodoItem todo=new TodoItem();
            

            string url = "http://localhost:5199/api/TodoItem";
            
            Client client = new Client();

            try
            {// Check if any of the input fields are empty
                if (string.IsNullOrWhiteSpace(textBoxPlace.Text) || string.IsNullOrWhiteSpace(textBoxThing.Text))
                {
                    MessageBox.Show("请填写所有字段！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                todo.TravelId = this.TravelId;
                todo.Time = dateTimePicker1.Value;// 限定时间要小于等于TravelTime
                if(todo.Time<TravelTime)
                {
                    MessageBox.Show("待办时间不能早于旅行开始时间！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // 退出方法，防止继续执行
                }
                todo.Place = textBoxPlace.Text;
                todo.Description=textBoxThing.Text;
                todo.IsCompleted = false;
                string jsonData = JsonConvert.SerializeObject(todo);
                HttpResponseMessage result = await client.Post(url, jsonData);
                if (result.IsSuccessStatusCode)
                {
                    MessageBox.Show("创建成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TodoAdded?.Invoke(this, EventArgs.Empty); // 触发事件
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
