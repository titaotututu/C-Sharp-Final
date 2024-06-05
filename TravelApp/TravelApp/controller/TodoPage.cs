using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using TravelApp.models;

namespace TravelApp.controller
{
    public partial class TodoPage : UserControl
    {
        public event EventHandler TodoDeleted;
        public event Action<Journal, Travel> JournalDetailRequested;

        TodoItem todo = new TodoItem();

        public TodoPage(TodoItem todo_)
        {
            todo = todo_;
            InitializeComponent();
            if(todo.IsCompleted)
            {
                buttonLight.Enabled = false;
                pictureBox.Visible = true;
            }
            labelTime.Text = todo.Time.ToString();
            this.labelPlace.Text = todo.Place.ToString();
            this.labelDescription.Text = todo.Description.ToString();
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            string url = "http://localhost:5199/api/TodoItem/delete?itemId=" + todo.ItemId;

            Client client = new Client();
            try
            {
                HttpResponseMessage result = await client.Delete(url);
                if (result.IsSuccessStatusCode)
                {
                    MessageBox.Show("删除成功！", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // 在此处添加删除成功后的逻辑，例如刷新界面或重新加载数据
                    TodoDeleted?.Invoke(this, EventArgs.Empty); // 触发事件
                }
                else
                {
                    string errorMessage = await result.Content.ReadAsStringAsync();
                    MessageBox.Show($"删除失败！ Error: {errorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // 根据travelid查travel
        private async Task<Travel> GetTravelById(long travelId)
        {
            string url = "http://localhost:5199/api/Travel/" + travelId;

            Client client = new Client();
            try
            {
                HttpResponseMessage response = await client.Get(url);
                if (response.IsSuccessStatusCode)
                {
                    string responseData = await response.Content.ReadAsStringAsync();
                    Travel travel = JsonConvert.DeserializeObject<Travel>(responseData);
                    return travel;
                }
                else
                {
                    // If the response is not successful, handle the error here
                    string errorMessage = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Failed to fetch travel information. Error: {errorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
            catch (Exception ex)
            {
                // If an exception occurs during the process, handle it here
                MessageBox.Show($"An error occurred while fetching travel information. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private async void buttonLight_Click(object sender, EventArgs e)
        {
            TodoItem newtodo = new TodoItem();
            newtodo.TravelId = todo.TravelId;
            newtodo.ItemId = todo.ItemId;
            newtodo.Time = todo.Time;
            newtodo.Place = todo.Place;
            newtodo.Description = todo.Description;
            newtodo.IsCompleted = true;
            pictureBox.Visible = true;

            string url = "http://localhost:5199/api/TodoItem/update?itemid=" + newtodo.ItemId;
            Client client = new Client();
            try
            {
                string jsonData = JsonConvert.SerializeObject(newtodo);
                HttpResponseMessage result = await client.Put(url, jsonData);
                if (result.IsSuccessStatusCode)
                {
                    MessageBox.Show("待办已完成！\n开始编写日志吧！", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    string errorMessage = await result.Content.ReadAsStringAsync();
                    MessageBox.Show($"Failed to change todo item. Error: {errorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            // 把travel对应的city传到点亮地图那里
            Travel nowtravel = await GetTravelById(todo.TravelId);
            string travelcity = nowtravel.TravelCity;
            Console.Write(travelcity);

            string journalUrl = "http://localhost:5199/api/Journal";

            Journal journal = new Journal();

            //初始化
            journal.JournalId = 0;
            journal.Time = DateTime.Now;
            journal.Title = "";
            journal.Weather = "";
            journal.Emotion = "";
            journal.Description = "";
            journal.Picture = "";
            journal.UserId = nowtravel.UserId;

            Client client_ = new Client();
            try
            {
                string data = JsonConvert.SerializeObject(journal);
                Console.WriteLine("Sending data: " + data); // 打印出发送的数据

                HttpResponseMessage result = await client_.Post(journalUrl, data);
                if (result.IsSuccessStatusCode)
                {
                    string jsonContent = await result.Content.ReadAsStringAsync();
                    journal = JsonConvert.DeserializeObject<Journal>(jsonContent);
                }
                else
                {
                    string responseContent = await result.Content.ReadAsStringAsync();
                    MessageBox.Show("无法创建日志对象: " + result.ReasonPhrase, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //跳转至TravelToDo界面
            JournalDetailRequested?.Invoke(journal, nowtravel);
        }
    }
}
