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
using ApplicationLayer;

namespace SocialMediaEventTeamS23B
{
    public partial class ReservationDetails : Form
    {
        List<String> members;
        public ReservationDetails(DataBaseConnection dbc)
        {
            InitializeComponent();
            members = new List<String>();
        }

        private void btnReservationDetailsNext_Click(object sender, EventArgs e)
        {
            ReservationLocation ResLocation = new ReservationLocation();
            ResLocation.Show();
        }

        private void btnReservationAddMember_Click(object sender, EventArgs e)
        {
            try
            {
                members.Add(tbUserNameMember.Text + ": " + tbReservationFirstNameMember.Text + ": " + tbReservationPrefixMember.Text + ": " + tbReservationLastNameMember.Text + ": " + tbReservationEmailaddressMember.Text);
                
            }
            catch(Exception ex)
            {

            }
            
            //Login.HashedBytes(Encoding.UTF8.GetBytes(string aaaa));//encoding
        }
    }
}
