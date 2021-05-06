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
    //Observers
    //The View
    public partial class TrainDisplay : Form, ITrainDisplay
    {
        private ITrainJourney trainJourney;
        public TrainDisplay(ITrainJourney trainJourney)
        {
            InitializeComponent();

            //Assigns the observer to the observable
            this.trainJourney = trainJourney;
            this.trainJourney.AddObserver(this);
        }

        public void Update(TrainStation currentTrainStation)
        {
            lbl_CurrentStation.Text = currentTrainStation.ToString();
        }
    }
}
