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
        TodoItem todo = new TodoItem();

        public TodoPage(TodoItem todo_)
        {
            todo = todo_;
            InitializeComponent();
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
                    MessageBox.Show("Todo item deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // 在此处添加删除成功后的逻辑，例如刷新界面或重新加载数据
                }
                else
                {
                    string errorMessage = await result.Content.ReadAsStringAsync();
                    MessageBox.Show($"Failed to delete todo item. Error: {errorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private async void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            TodoItem newtodo =new TodoItem();
            newtodo.TravelId=todo.TravelId;
            newtodo.ItemId=todo.ItemId;
            newtodo.Time=todo.Time;
            newtodo.Place=todo.Place;
            newtodo.Description=todo.Description;
            newtodo.IsCompleted=checkBox1.Checked;
            string url = "http://localhost:5199/api/TodoItem/update?itemid=" + newtodo.ItemId;
            Client client = new Client();
            try
            {
                string jsonData = JsonConvert.SerializeObject(newtodo);
                HttpResponseMessage result = await client.Put(url,jsonData);
                if (result.IsSuccessStatusCode)
                {
                    MessageBox.Show("Change successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // 在此处添加删除成功后的逻辑，例如刷新界面或重新加载数据
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
        }
    }
}
