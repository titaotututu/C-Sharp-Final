using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Weather_space;

namespace TravelApp
{
    public partial class MainInterface : Form
    {
        public MainInterface()
        {
            InitializeComponent();
        }

        private void MainInterface_Load(object sender, EventArgs e)
        {

        }

        private void button_guide_Click(object sender, EventArgs e)
        {
            OpenForm(new Navigation());
        }
      
        private void button_light_Click(object sender, EventArgs e)
        {
            OpenForm(new Lighting());
        }
        private void OpenForm(Form form)
        {
            form.Show();
        }

        private void button_weather_Click(object sender, EventArgs e)
        {
            OpenForm(new Weather());
        }
    }
}
