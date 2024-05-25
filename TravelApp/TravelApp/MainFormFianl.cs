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
    public delegate void ChangePanel(Control c);
    public partial class MainFormFianl : Form
    {
        private Point formPoint = new Point();
        public ChangePanel changePanel;
        int Uid;
        public MainFormFianl()
        {
            InitializeComponent();
        }

        public void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControl.Controls.Clear();
            panelControl.Controls.Add(c);
        }

        private void button_Weather_Click(object sender, EventArgs e)
        {
            Travel_Weather travel_weather= new Travel_Weather(changePanel);
            AddControlsToPanel(travel_weather);
        }
    }
}
