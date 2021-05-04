using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PilotCodeFormsSample.Classes;

namespace PilotCodeFormsSample
{
    public partial class Form1 : Form
    {
        private Data _data = new Data();
        public Form1()
        {
            InitializeComponent();
            Shown += OnShown;
        }

        private void OnShown(object? sender, EventArgs e)
        {
            _data = JsonHelpers.ReadJsonFromFile<Data>("data.json");
            
            PilotComboBox.DataSource = _data.pilots.Select(pilot => pilot.callsign).ToList();

            var callSignIndex = PilotComboBox.FindString("CXA106");
            PilotComboBox.SelectedIndexChanged += PilotComboBoxOnSelectedIndexChanged;
            if (callSignIndex > -1)
            {
                PilotComboBox.SelectedIndex = callSignIndex;
            }

            ActiveControl = PilotComboBox;
        }

        private void PilotComboBoxOnSelectedIndexChanged(object? sender, EventArgs e)
        {
            ShowFlightPlan();
        }

        private void ShowFlightPlan()
        {
            var pilot = _data.pilots
                .FirstOrDefault(pilotInstance =>
                    pilotInstance.callsign == PilotComboBox.Text);

            var flightPlan = pilot.flight_plan;

            textBoxDeparture.Text = flightPlan.Departure;
            textBoxArrival.Text = flightPlan.Arrival;
            textBoxAlternate.Text = flightPlan.Alternate;
            textBoxAltitude.Text = flightPlan.Altitude;
            textBoxFlightPlan.Text = flightPlan.Route;
        }
    }
}
