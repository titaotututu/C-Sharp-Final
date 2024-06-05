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
        DateTime TravelTime;
        public TravelTodo(long travelid,string traveltitle,DateTime traveltime)
        {   this.TravelTitle=traveltitle;
            this.TravelId=travelid;
            this.TravelTime=traveltime;
            InitializeComponent();
            this.labelTravelTitle.Text = TravelTitle;
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
                    int yPosition = 20; // 起始位置
                    List<TodoItem> todoItems = JsonConvert.DeserializeObject<List<TodoItem>>(jsonContent);
                    foreach (TodoItem todo in todoItems)
                    {
                        // 添加到panel中
                        TodoPage todoPage = new TodoPage(todo);
                        todoPage.TodoDeleted += TodoPage_TodoDeleted; // 订阅事件
                        todoPage.JournalDetailRequested += SwitchToJournalDetail; // 订阅切换事件
                        todoPage.Location = new Point(0, yPosition); // 设置位置
                        panelTodo.Controls.Add(todoPage);
                        yPosition += todoPage.Height + 20; // 更新y位置
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
            AddTodo addtodo = new AddTodo(TravelId,TravelTime);
            addtodo.TodoAdded += AddTodo_TodoAdded; // 订阅事件
            panelTodo.Controls.Clear();
            panelTodo.Controls.Add(addtodo);

        }
        private void AddTodo_TodoAdded(object sender, EventArgs e)
        {
            panelTodo.Controls.Clear();
            getTask();
            
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            panelTodo.Controls.Clear();
            getTask();
        }
        private void TodoPage_TodoDeleted(object sender, EventArgs e)
        {
            panelTodo.Controls.Clear();
            getTask();
        }

        public void SwitchToJournalDetail(Journal journal, Travel travel)
        {
            panelTodo.Controls.Clear();
            JournalDetail journalDetail = new JournalDetail(journal, travel);
            journalDetail.Dock = DockStyle.Fill;
            journalDetail.BackToTravelTodoRequested += BackFromJournalDetail;
            panelTodo.Controls.Add(journalDetail);
        }
        private void BackFromJournalDetail(object sender, EventArgs e)
        {
            panelTodo.Controls.Clear();
            getTask();
        }
    }
}
