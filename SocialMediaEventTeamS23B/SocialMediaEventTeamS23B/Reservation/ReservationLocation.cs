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
using DatabaseConnection.Exceptions;

namespace SocialMediaEventTeamS23B
{
    public partial class ReservationLocation : Form
    {
        private Visitor leader;
        private List<Visitor> members = new List<Visitor>();
        private List<MapLocation> maplocations = new List<MapLocation>();

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

        /// <summary>
        /// make the buttons on the map
        /// </summary>
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

        /// <summary>
        /// event hander for button click:
        ///     for getting location of the button > to insert into database the location of a reservation.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// get location data from database.
        /// </summary>
        private void GetLocationData()
        {
            NOTresMapLocations = res.GetNOTReserverdMapLocations();
        }

        /// <summary>
        /// button 2 click event handler: add a maplocation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (maplocation != null)
            {
                maplocations.Add(maplocation);
            }
            else
            {
                throw new InvalidDataException("selecteer een locatie");
            } 
        }

        /// <summary>
        /// open form of material adding
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReservationLocationNext_Click(object sender, EventArgs e)
        {
            ReservationMaterial ResMaterial = new ReservationMaterial(leader, members, maplocations);
            ResMaterial.Show();
        }

        /// <summary>
        /// close this form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReservationLocationPrevious_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
