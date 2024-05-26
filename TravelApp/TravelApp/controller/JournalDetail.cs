using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using TravelApp.models;

namespace TravelApp.controller
{
    public partial class JournalDetail : UserControl
    {
        private readonly long JournalId;
        private readonly ChangePanel ChangePanel;
        private readonly string baseUrl = "https://localhost:5199/api/Journal";
        private Refresh Refresh;
        public JournalDetail(long journalId, ChangePanel changePanel)
        {
            InitializeComponent();
            JournalId = journalId;
            ChangePanel = changePanel;
            Refresh = ImgRefresh;
        }
        private async void Init()
        {
            Journal journal = await GetJournal();
            tbTitle.Enabled = false;
            tbWeather.Enabled = false;
            tbEmotion.Enabled = false;
            pbAdd.Enabled = false;
            btnSave.Enabled = false;
            rtbDescription.Enabled = false;
            tbTitle.Text = journal.Title;
            rtbDescription.Text = journal.Description;

            LoadImg(journal.Picture);
        }
        private async Task<Journal> GetJournal()
        {
            //根据id获取diary
            string url = this.baseUrl + "/get?journalId=" + this.JournalId;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Journal));
            Client client = new Client();
            Journal journal = null;
            try
            {
                HttpResponseMessage result = await client.Get(url);
                if (result.IsSuccessStatusCode)
                {
                    journal = (Journal)xmlSerializer.Deserialize(await result.Content.ReadAsStreamAsync());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return journal;
        }
        private async void LoadImg(string photo)
        {
            flpImage.Controls.Clear();
            if (photo != null)
            {
                string[] imgNames = photo.Trim().Split(' ');

                //未知 要修改
                string imgUrl = "???";

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
                        pb.picBox.Image = ResizeImage(image, new Size(200, 200));
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
            JournalList journalList = new JournalList(journal.UserId, this.ChangePanel);
            this.ChangePanel(journalList);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnEdit.Enabled = false;
            btnEdit.Text = "编辑中";
            tbTitle.Enabled = true;
            tbWeather.Enabled = true;
            tbEmotion.Enabled = true;
            btnSave.Enabled = true;
            pbAdd.Enabled = true;
            rtbDescription.Enabled = true;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            tbTitle.Enabled = false;
            tbWeather.Enabled = false;
            tbEmotion.Enabled = false;
            btnSave.Enabled = false;
            pbAdd.Enabled = false;
            rtbDescription.Enabled = false;
            //将修改传到远端
            Journal journal = await GetJournal();
            journal.Title = tbTitle.Text;
            journal.Description = rtbDescription.Text;
            
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
            }
        }
    }
}
