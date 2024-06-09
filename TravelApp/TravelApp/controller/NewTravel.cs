using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using TravelApp.models;
using Newtonsoft.Json;

namespace TravelApp.controller
{
    public partial class NewTravel : UserControl
    {
        long Uid;
        public NewTravel(long uid)
        {
            InitializeComponent();
            this.Uid = uid;

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {// Check if any of the input fields are empty
            if (string.IsNullOrWhiteSpace(textTravelTitle.Text) || string.IsNullOrWhiteSpace(textTravelCity.Text))
            {
                MessageBox.Show("请填写所有字段！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string title = textTravelTitle.Text; // Assuming textBoxTitle is the TextBox for travel title
            string city = textTravelCity.Text; // Assuming textBoxCity is the TextBox for travel city
           // string time = textTravelTime.Text; // Assuming textBoxTime is the TextBox for travel time
           DateTime time=dateTimePicker1.Value;
            long uid = Uid; // Assuming uid is hardcoded or retrieved from somewhere
            // 应该要再增加一个判断city字段是不是合法的城市。便于点亮地图。

            // Call AddTravel method with the extracted values
            AddTravel(title, city, time,uid);
            
        }

        private async void AddTravel(string title,string city,DateTime time,long uid)
        {


            Travel travel = new Travel();
            Client client = new Client();
            

            try
            {
                string url = "http://localhost:5199/api/Travel";
                travel.TravelTitle = title;
                
                travel.UserId = uid;
                travel.TravelCity = city;
                travel.TodoItems = new List<TodoItem>();
                
                travel.TravelTime = time;
                string jsonData = JsonConvert.SerializeObject(travel);
                Console.WriteLine(jsonData);
                HttpResponseMessage result = await client.Post(url, jsonData);
                if (result.IsSuccessStatusCode)
                {
                    string responseData = await result.Content.ReadAsStringAsync();
                    dynamic responseObject = JsonConvert.DeserializeObject(responseData);

                    // 获取返回的 travelId
                    travel.TravelId = responseObject.travelId;
                    MessageBox.Show("新行程已添加成功!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // 跳转到待办界面
                    // 这里get到的id是0.因为id是在加入数据库的时候自己生成的、、
                    // 解决：在这边模拟生成id的方法进行生成。（好麻烦）
                    // 有个小bug。不同用户的冲突（）
                    // 就是数据库会正常生成，但是我这里拿不到这个id
                    // 修改了api 解决该问题
                   // travel.TravelId = await  GenerateTravelId(uid);
                    TravelTodo travelTodoForm = new TravelTodo(travel.TravelId, travel.TravelTitle,travel.TravelTime);
                    travelTodoForm.Show();
                }
                else
                {
                    string errorMessage = await result.Content.ReadAsStringAsync();
                    MessageBox.Show($"行程添加失败. Error: {errorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // 不需要该方法了
        private async Task<long> GenerateTravelId(long uid)
        {
            string date = DateTime.Now.ToString("yyyyMMdd");
            long travelId= System.Convert.ToInt64(date + "0000");
            // 调用 API 获取所有 travel 记录
            string url = "http://localhost:5199/api/Travel/get?uid=" + uid;
            Client client = new Client();
            HttpResponseMessage response = await client.Get(url);

            if (response.IsSuccessStatusCode)
            {
                string jsonContent = await response.Content.ReadAsStringAsync();
                List<Travel> travels = JsonConvert.DeserializeObject<List<Travel>>(jsonContent);

                // 在本地处理获取最大 travelId
                long maxTravelId = travels.Max(t => t.TravelId);

                // 如果最大 travelId 大于当前 travelId，则使用最大 travelId 加 1
                if (maxTravelId >= travelId)
                {
                    travelId = maxTravelId + 1;
                }
            }

            return travelId-1;
        }


    }
}
