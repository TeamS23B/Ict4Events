﻿using System;
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
        public List<Visitor> resmembers { get; private set; }
        public Visitor resleader { get; private set; }
        
        private string newRFID = "";
        private static int counter = 1000000;
        public ReservationDetails(Visitor leader, List<Visitor> members)
        {
            InitializeComponent();
            resmembers = new List<Visitor>();
            resleader = leader;
            if (members != null)
            {
                resmembers = members;
            }
            AddLbMembers(leader);
        }

        /// <summary>
        /// shows the locations which are available to rent 
        /// Makes an address and a leader for the event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 

        private string RFIDCount()
        {
            string a = "dcq";
            counter++;
            return newRFID = counter.ToString() + a;
        }
        private void btnReservationDetailsNext_Click(object sender, EventArgs e)
        {
            try
            {
                string RFID = RFIDCount();
                AdressInfo adressinfo = new AdressInfo(tbReservationStreetName.Text, tbReservationResidence.Text, Convert.ToInt32(tbReservationHouseNumber.Text), tbReservationZipCode.Text);
                resleader = new Visitor(tbUserName.Text, tbReservationFirstNameLeader.Text, tbReservationPrefixLeader.Text, tbReservationLastNameLeader.Text, tbReservationEmailaddressLeader.Text, tbReservationIBAN.Text, adressinfo,RFID,false);
                ReservationLocation ResLocation = new ReservationLocation(resleader, resmembers, null);
                ResLocation.Show();
                this.Close();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }     
        }
        /// <summary>
        /// Adds the members of the reservation
        /// </summary>
        private void AddLbMembers(Visitor Leader)
        {
            lbReservationMembers.Items.Clear();
            if (resmembers != null)
            {
                foreach (Visitor V in resmembers)
                {
                    lbReservationMembers.Items.Add(V.Name + ": " + V.Username);
                }
            }
            if (Leader != null)
            {
                tbUserName.Text = Leader.Username;
                tbReservationFirstNameLeader.Text = Leader.Name;
                tbReservationLastNameLeader.Text = Leader.Surname;
                tbReservationPrefixLeader.Text = Leader.Prefix;
                tbReservationResidence.Text = Leader.Adress.City;
                tbReservationStreetName.Text = Leader.Adress.Street;
                tbReservationZipCode.Text = Leader.Adress.Postalcode;
                tbReservationHouseNumber.Text = Leader.Adress.Number.ToString();
                tbReservationEmailaddressLeader.Text = Leader.Email;
                tbReservationIBAN.Text = Leader.IBAN;
            }
        }
        /// <summary>
        /// adds the members to the listbox (groups)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReservationAddMember_Click(object sender, EventArgs e)
        {
            try
            {
                resmembers.Add(new Visitor(tbUserNameMember.Text, tbReservationFirstNameMember.Text, tbReservationPrefixMember.Text, tbReservationLastNameMember.Text, tbReservationEmailaddressMember.Text, tbUserNameMember.Text,false));
                AddLbMembers(null);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            //Login.HashedBytes(Encoding.UTF8.GetBytes(string aaaa));//encoding
        }

        /// <summary>
        /// removes member from the reservations (of the members in the group)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReservationRemoveMember_Click(object sender, EventArgs e)
        {
            try
            {
                Visitor SelectedVisitor = null;
                foreach(Visitor V in resmembers)
                {
                    if(lbReservationMembers.SelectedItem.ToString() == V.Name + ": " + V.Username)
                    {
                        lbReservationMembers.Items.Remove(V);
                        SelectedVisitor = V;
                    }
                }
                resmembers.Remove(SelectedVisitor);
                AddLbMembers(null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
