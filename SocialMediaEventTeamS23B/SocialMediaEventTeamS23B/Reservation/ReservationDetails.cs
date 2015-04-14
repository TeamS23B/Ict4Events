using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseConnection;
using DatabaseConnection.Types;

namespace SocialMediaEventTeamS23B
{
    public partial class ReservationDetails : Form
    {
        
        public ReservationDetails(DataBaseConnection dbc)
        {
            InitializeComponent();
        }

        private void btnReservationDetailsNext_Click(object sender, EventArgs e)
        {
            ReservationLocation ResLocation = new ReservationLocation();
            ResLocation.Show();
        }

        private void btnReservationAddMember_Click(object sender, EventArgs e)
        {

        }
    }
}
