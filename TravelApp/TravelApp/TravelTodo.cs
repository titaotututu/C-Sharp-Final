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
using TravelApp.controller;
using TravelApp.models;

namespace TravelApp
{
    public partial class TravelTodo : Form
    {
        long TravelId;
        string TravelTitle;
        public TravelTodo(long travelid,string traveltitle)
        {   this.TravelTitle=traveltitle;
            this.TravelId=travelid;
            InitializeComponent();
            getTask();
            
        }


        public async void getTask()
        {
            string url = "http://localhost:5199/api/TodoItem/get?travelId=" + TravelId;
            
            Client client = new Client();
            panelTodo.Controls.Clear();
            try
            {
                HttpResponseMessage result = await client.Get(url);
                if (result.IsSuccessStatusCode)
                {
                    string jsonContent = await result.Content.ReadAsStringAsync();
                    
                    List<TodoItem> todoItems = JsonConvert.DeserializeObject<List<TodoItem>>(jsonContent);
                    foreach (TodoItem todo in todoItems)
                    {
                        // 添加到panel中
                        TodoPage todoPage = new TodoPage(todo);
                        
                        panelTodo.Controls.Add(todoPage);
                    }
                }
                else
                {
                    string errorMessage = await result.Content.ReadAsStringAsync();
                    MessageBox.Show($"Failed to show todoitem.Error: {errorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonAddTodo_Click(object sender, EventArgs e)
        {
            // addtodo
            AddTodo addtodo = new AddTodo(TravelId);
            panelTodo.Controls.Clear();
            panelTodo.Controls.Add(addtodo);

        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            panelTodo.Controls.Clear();
            getTask();
        }
    }
}
