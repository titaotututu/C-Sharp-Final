using System;
using System.Windows.Forms;
using TravelApp.models;

namespace TravelApp.controller
{
    public delegate void Delegate_init();
    

    public partial class MyTravel : UserControl
    {
        public Delegate_init init;
        public ChangePanel changePanel;

        long Uid;
        
        public MyTravel(ChangePanel changePanel)// 后面要补一个uid
        {
            InitializeComponent();
            this.changePanel = changePanel;
            
        }

        private void buttonOldTravel_Click(object sender, EventArgs e)
        {

            OldTravel oldtravel = new OldTravel();
            panelTravel.Controls.Clear();
            panelTravel.Controls.Add(oldtravel);

        }

        private void buttonNewTravel_Click(object sender, EventArgs e)
        {
            NewTravel newtravel = new NewTravel();
            panelTravel.Controls.Clear();
            panelTravel.Controls.Add(newtravel);
        }
    }
}
