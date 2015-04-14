using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseConnection.Types;
using ApplicationLayer;

namespace SocialMediaEventTeamS23B
{
    public partial class ReservationLocation : Form
    {
        ApplicationLayer.Reservations res;
        private List<MapLocation> mapLocations;
        public ReservationLocation()
        {
            InitializeComponent();
            res = new Reservations();
            mapLocations = new List<MapLocation>();
            GetLocationData();
            MakeButtons();
        }

        private void MakeButtons()
        {

        }

        private void GetLocationData()
        {
            mapLocations = res.GetMapLocations();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnReservationLocationNext_Click(object sender, EventArgs e)
        {
            ReservationMaterial ResMaterial = new ReservationMaterial();
            ResMaterial.Show();
        }

        private void pictureBoxReservationLocationLocation_Click(object sender, EventArgs e)
        {
            
        }
    }
}
