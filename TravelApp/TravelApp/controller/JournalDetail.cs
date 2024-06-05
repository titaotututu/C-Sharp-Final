using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using TravelApp.models;

namespace TravelApp.controller
{
    public partial class JournalDetail : UserControl
    {
        public long JournalId;
        public string baseUrl = "http://localhost:5199/api/Journal";
        public ChangePanel ChangePanel;
        public Refresh Refresh;
        public bool IsFromToDo;
        public Travel travel;

        public event EventHandler BackToTravelTodoRequested;

        public JournalDetail(Journal journal, ChangePanel changePanel)
        {
            InitializeComponent();
            IsFromToDo = false;
            this.ChangePanel = changePanel;
            this.Refresh = ImgRefresh;
            Init0(journal);
        }
        public JournalDetail(Journal journal, Travel travel)
        {
            InitializeComponent();
            this.travel = travel;
            IsFromToDo = true;
            this.Refresh = ImgRefresh;
            Init0(journal);
        }
        public JournalDetail(long journalId, ChangePanel changePanel)
        {
            InitializeComponent();
            IsFromToDo = false;
            this.JournalId = journalId;
            this.ChangePanel = changePanel;
            this.Refresh = ImgRefresh;
            Init();
        }
        public void Init0(Journal journal)
        {
            this.JournalId = journal.JournalId;
            journal.Time = DateTime.Now;
            lblTime.Text = journal.Time.ToString();
            tbTitle.Text = "请输入标题...";
            tbWeather.Text = "未知";
            tbEmotion.Text = "无";
            rtbDescription.Text = "请输入描述......";
            btnEdit.Enabled = false;
            btnEdit.Text = "编辑中";
            pbBack.Enabled = false;
        }
        public async void Init()
        {
            Journal journal = await GetJournal();

            tbTitle.Text = journal.Title;
            rtbDescription.Text = journal.Description;
            tbEmotion.Text = journal.Emotion;
            tbWeather.Text = journal.Weather;
            lblTime.Text = journal.Time.ToString();
            LoadImg(journal.Picture);

            pbBack.Enabled = true;
            tbTitle.Enabled = false;
            tbWeather.Enabled = false;
            tbEmotion.Enabled = false;
            pbAdd.Enabled = false;
            btnSave.Enabled = false;
            rtbDescription.Enabled = false;
            //flpImage.Enabled = false;
        }
        public async Task<Journal> GetJournal()
        {
            //根据id获取journal
            string url = this.baseUrl + "/get?journalId=" + this.JournalId;

            Client client = new Client();
            Journal journal = new Journal();
            try
            {
                HttpResponseMessage result = await client.Get(url);
                if (result.IsSuccessStatusCode)
                {
                    string jsonContent = await result.Content.ReadAsStringAsync();
                    journal = JsonConvert.DeserializeObject<Journal>(jsonContent);
                }
                else
                {
                    MessageBox.Show("无法获取日志对象: " + result.ReasonPhrase, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return journal;
        }

        public async Task<bool> PutJournal(Journal journal)
        {
            string url = this.baseUrl + "/update?journalId=" + journal.JournalId;

            Client client = new Client();

            try
            {
                string data = JsonConvert.SerializeObject(journal);
                Console.WriteLine("PUT URL: " + url);
                Console.WriteLine("PUT Data: " + data);

                HttpResponseMessage result = await client.Put(url, data);
                Console.WriteLine("Response Status Code: " + result.StatusCode);

                if (result.IsSuccessStatusCode)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        private async void LoadImg(string photo)
        {
            flpImage.Controls.Clear();
            if (photo != null)
            {
                string[] imgNames = photo.Trim().Split(' ');

                //未知 要修改
                string imgUrl = "http://localhost:5199/api/File/download?fileName=";

                PictureBox pb;
                Image image;
                FileClient fileClient = new FileClient();
                foreach (string name in imgNames)
                {
                    string url = imgUrl + name;
                    pb = new PictureBox(this.JournalId, name, this.Refresh);
                    image = await fileClient.Download(url);
                    if (image != null)
                    {
                        pb.picBox.Image = ResizeImage(image, new Size(280, 160));
                        pb.Anchor = AnchorStyles.None;
                        flpImage.Controls.Add(pb);
                    }
                }
            }
        }
        private Image ResizeImage(Image imgToResize, Size size)
        {
            //获取图片宽度
            int sourceWidth = imgToResize.Width;
            //获取图片高度
            int sourceHeight = imgToResize.Height;

            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;
            //计算宽度的缩放比例
            nPercentW = ((float)size.Width / (float)sourceWidth);
            //计算高度的缩放比例
            nPercentH = ((float)size.Height / (float)sourceHeight);

            if (nPercentH < nPercentW)
                nPercent = nPercentH;
            else
                nPercent = nPercentW;
            //期望的宽度
            int destWidth = (int)(sourceWidth * nPercent);
            //期望的高度
            int destHeight = (int)(sourceHeight * nPercent);

            Bitmap b = new Bitmap(destWidth, destHeight);
            Graphics g = Graphics.FromImage((Image)b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            //绘制图像
            g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
            g.Dispose();
            return (Image)b;
        }
        private async void ImgRefresh()
        {
            Journal journal = await GetJournal();
            LoadImg(journal.Picture);
        }

        private async void pbBack_Click(object sender, EventArgs e)
        {
            Journal journal = await GetJournal();
            if(IsFromToDo)
            {
                BackToTravelTodoRequested?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                JournalList journalList = new JournalList(journal.UserId, this.ChangePanel);

                panelControl.Controls.Clear();
                panelControl.BringToFront();
                panelControl.Controls.Add(journalList);
            }    
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            pbBack.Enabled = false;
            btnEdit.Enabled = false;
            btnEdit.Text = "编辑中";
            tbTitle.Enabled = true;
            tbWeather.Enabled = true;
            tbEmotion.Enabled = true;
            btnSave.Enabled = true;
            pbAdd.Enabled = true;
            rtbDescription.Enabled = true;
            //flpImage.Enabled = true;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            pbBack.Enabled = true;
            tbTitle.Enabled = false;
            tbWeather.Enabled = false;
            tbEmotion.Enabled = false;
            btnSave.Enabled = false;
            pbAdd.Enabled = false;
            rtbDescription.Enabled = false;
            //flpImage.Enabled = false;

            //将修改传到远端
            Journal journal = await GetJournal();
            if (journal == null)
            {
                MessageBox.Show("无法获取日志对象", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            journal.Title = tbTitle.Text;
            journal.Description = rtbDescription.Text;
            journal.Emotion = tbEmotion.Text;
            journal.Weather = tbWeather.Text;
         
            if (await PutJournal(journal))
            {
                MessageBox.Show("保存成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("保存失败", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            //将编辑激活
            btnEdit.Enabled = true;
            btnEdit.Text = "编辑";
        }

        private async void pbAdd_Click(object sender, EventArgs e)
        {
            string filePath = "";
            FileClient fileClient = new FileClient();
            //添加图片：打开文件管理器，选择图片进行上传
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "选择上传的图片";
            openFileDialog.InitialDirectory = @"C:\";
            openFileDialog.Filter = "图片文件|*.jpg;*.gif;*.jpeg;*.png";
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = Path.GetFullPath(openFileDialog.FileName);
            }
            try
            {
                if (await fileClient.Upload(this.JournalId, filePath))
                {
                    ImgRefresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "上传失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               
                // 在控制台输出异常详细信息（或记录到日志文件）  
                Console.WriteLine("异常类型: " + ex.GetType().Name);
                Console.WriteLine("异常消息: " + ex.Message);
                Console.WriteLine("异常堆栈跟踪: ");
                Console.WriteLine(ex.StackTrace);

                // 如果异常有内部异常，也打印出来  
                if (ex.InnerException != null)
                {
                    Console.WriteLine("内部异常类型: " + ex.InnerException.GetType().Name);
                    Console.WriteLine("内部异常消息: " + ex.InnerException.Message);
                    Console.WriteLine("内部异常堆栈跟踪: ");
                    Console.WriteLine(ex.InnerException.StackTrace);
                }
            }
        }
    }
}
