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
        List<Visitor> members;
        Visitor leader;
        public ReservationDetails(DataBaseConnection dbc)
        {
            InitializeComponent();
            members = new List<Visitor>();
        }

        private void btnReservationDetailsNext_Click(object sender, EventArgs e)
        {
            try
            {
                AdressInfo adressinfo = new AdressInfo(tbReservationStreetName.Text, tbReservationResidence.Text, Convert.ToInt32(tbReservationHouseNumber.Text), tbReservationZipCode.Text);
                leader = new Visitor(tbUserName.Text, tbReservationFirstNameLeader.Text, tbReservationPrefixLeader.Text, tbReservationLastNameLeader.Text, tbReservationEmailaddressLeader.Text, tbReservationIBAN.Text, adressinfo,/*RFID nu combo van username en first name*/tbUserNameMember.Text + tbReservationFirstNameMember.Text);
                ReservationLocation ResLocation = new ReservationLocation();
                ResLocation.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }     
        }
        private void AddLbMembers()
        {
            foreach (Visitor V in members)
            {
                lbReservationMembers.Items.Add(V.Name + ": " + V.Username);
            }
        }
        private void btnReservationAddMember_Click(object sender, EventArgs e)
        {
            try
            {
                members.Add(new Visitor(tbUserNameMember.Text, tbReservationFirstNameMember.Text, tbReservationPrefixMember.Text, tbReservationLastNameMember.Text, tbReservationEmailaddressMember.Text, tbUserNameMember.Text + tbReservationFirstNameMember.Text));
                AddLbMembers();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            //Login.HashedBytes(Encoding.UTF8.GetBytes(string aaaa));//encoding
        }

        private void btnReservationRemoveMember_Click(object sender, EventArgs e)
        {
            try
            {
                Visitor SelectedVisitor = null;
                foreach(Visitor V in members)
                {
                    if(lbReservationMembers.SelectedItem.ToString() == V.Name + ": " + V.Username)
                    {
                        lbReservationMembers.Items.Remove(V);
                        SelectedVisitor = V;
                    }
                }
                members.Remove(SelectedVisitor);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
