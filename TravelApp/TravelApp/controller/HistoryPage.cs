﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelApp.models;

namespace TravelApp.controller
{
    public partial class HistoryPage : UserControl
    {
        Travel travel = new Travel();
        public HistoryPage(Travel travel_)
        {
            this.travel = travel_;
            InitializeComponent();
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            string url = "http://localhost:5199/api/Travel/delete?travelId=" + travel.TravelId;

            Client client = new Client();
            try
            {
                HttpResponseMessage result = await client.Delete(url);
                if (result.IsSuccessStatusCode)
                {
                    MessageBox.Show("Travel deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // 在此处添加删除成功后的逻辑，例如刷新界面或重新加载数据
                }
                else
                {
                    string errorMessage = await result.Content.ReadAsStringAsync();
                    MessageBox.Show($"Failed to delete travel. Error: {errorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {
            TravelTodo travelTodoForm = new TravelTodo(travel.TravelId, travel.TravelTitle);
            travelTodoForm.Show();
        }
    }
}