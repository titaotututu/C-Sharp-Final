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
        
        public MyTravel(ChangePanel changePanel,long uid)// 后面要补一个uid
        {
            InitializeComponent();
            this.changePanel = changePanel;
            this.Uid=uid;
            
        }

        private void buttonOldTravel_Click(object sender, EventArgs e)
        {

            OldTravel oldtravel = new OldTravel(Uid);
            panelTravel.Controls.Clear();
            panelTravel.Controls.Add(oldtravel);

        }

        private void buttonNewTravel_Click(object sender, EventArgs e)
        {
            NewTravel newtravel = new NewTravel(Uid);
            panelTravel.Controls.Clear();
            panelTravel.Controls.Add(newtravel);
        }

        private void MyTravel_Load(object sender, EventArgs e)
        {

        }
    }
}
