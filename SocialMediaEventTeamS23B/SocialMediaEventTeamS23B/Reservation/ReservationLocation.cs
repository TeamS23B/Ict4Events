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
        private Visitor leader;
        private List<Visitor> members = new List<Visitor>();
        private MapLocation maplocation;

        private ApplicationLayer.Reservations res;
        private List<MapLocation> NOTresMapLocations;
        private List<Button> b;
        public ReservationLocation(Visitor leader, List<Visitor> members)
        {
            InitializeComponent();
            this.leader = leader;
            this.members = members;
            res = new Reservations();
            NOTresMapLocations = new List<MapLocation>();
            b = new List<Button>();
            GetLocationData();
            MakeButtons();
        }

        private void MakeButtons()
        {
            foreach (MapLocation ML in NOTresMapLocations)
            { 
                string name = ML.LocationNumber.ToString();
                Button button = new Button();
                button.Name = name;
                button.Left = ML.Coordinates.X;
                button.Top = ML.Coordinates.Y;
                button.Width = ML.Seize.X;
                button.Height = ML.Seize.Y;
                button.FlatStyle = FlatStyle.Flat;
                button.BackColor = Color.Transparent;
                button.Click += button_Click;
                this.Controls.Add(button);
                button.BringToFront();
                b.Add(button);
            }
        }

        void button_Click(object sender, EventArgs e)
        {
            var bt = (Button)sender;
            foreach(MapLocation ML in NOTresMapLocations)
            {
                if (bt.Left == ML.Coordinates.X && bt.Top == ML.Coordinates.Y)
                {
                    lblReservationLocationBungalow.Text = ML.Cat;
                    maplocation = ML;
                }
            }
        }

        private void GetLocationData()
        {
            NOTresMapLocations = res.GetNOTReserverdMapLocations();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnReservationLocationNext_Click(object sender, EventArgs e)
        {
            ReservationMaterial ResMaterial = new ReservationMaterial(leader, members, maplocation);
            ResMaterial.Show();
        }

        private void pictureBoxReservationLocationLocation_Click(object sender, EventArgs e)
        {
            
        }

        private void btnReservationLocationPrevious_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
