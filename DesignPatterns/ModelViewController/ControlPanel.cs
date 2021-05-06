using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    //Controls the display
    public partial class ControlPanel : Form
    {
        private ITrainJourney trainJourney;
        private ITrainController controller;
        public ControlPanel(ITrainJourney trainJourney, ITrainController controller)
        {
            InitializeComponent();

            this.trainJourney = trainJourney;
            this.controller = controller;
        }

        private void btn_NextStation_Click(object sender, EventArgs e)
        {
            controller.NextTrainStation();
            //Goes to: TrainController (NextTrainStation()) 
            //--> TrainJourney (NextTrainStation() --> NotifyTrainStationObservers() ) 
            //--> TrainDisplay (Update() )
        }

        private void btn_NewDisplay_Click(object sender, EventArgs e)
        {
            //Creates a new observer
            TrainDisplay display = new TrainDisplay(trainJourney);
            display.Show();
        }

    }
}
