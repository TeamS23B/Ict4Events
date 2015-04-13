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

namespace SocialMediaEventTeamS23B.Beheer_Forms
{
    public partial class Beheer___Event_Aanmaken : Form
    {
        Admin admin = new Admin();
        List<Location> locations = new List<Location>();
        public Beheer___Event_Aanmaken()
        {
            InitializeComponent();
            GetLocations();
        }

        private void GetLocations()
        {
            cbLocations.Items.Clear();
            locations = admin.GetLocations();
            foreach(Location L in locations)
            {
                cbLocations.Items.Add(L.Town +" "+ L.Street);
            }
            
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            Location EventLocation = null;
            foreach(Location L in locations)
            {
                string townSteet = L.Town +" "+ L.Street;
                if(cbLocations.ToString() == townSteet)
                {
                    EventLocation = L;
                }
            }
            DateTime startDate = new DateTime((int)nudStartYear.Value, (int)nudStartMonth.Value, (int)nudStartDay.Value);
            DateTime endDate = new DateTime((int)nudEndYear.Value, (int)nudEndMonth.Value, (int)nudEndDay.Value);
            admin.AddEvent(EventLocation, tbName.Text, startDate, endDate);
        }
    }
}
