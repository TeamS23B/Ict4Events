﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApplicationLayer;
using DatabaseConnection;
using DatabaseConnection.Exceptions;
using DatabaseConnection.Types;
using Phidgets;
using Phidgets.Events;

namespace SocialMediaEventTeamS23B
{
    public partial class MaterialRent : Form
    {
        private RFID rfid;
        private Material SelectedMaterial;
        private ApplicationLayer.MaterialRentInfo MaterialRentInfoS;
        private MaterialRentInfo MaterialRentCheckConnection;
        private List<Material> ListMaterials = new List<Material>();
        private DataBaseConnection dbConnection;
        private List<Material> RentedMaterial = new List<Material>();
        public MaterialRent(DataBaseConnection dbc)
        {
            InitializeComponent();
            gbRfidScan.Enabled = false;
            btnReattach.Visible = false;
            FillsListboxWithItemsForEvent();
            rfid = new RFID();
            rfid.open();

            MaterialRentInfoS = new MaterialRentInfo(dbConnection);

            rfid.Attach += rfid_Attach;
            rfid.Detach += rfid_Detach;
            rfid.Error += rfid_Error;

            rfid.Tag += rfid_Tag;
            rfid.TagLost += rfid_TagLost;
        }
        /// <summary>
        /// method to fill the listbox with information from the database
        //  it selects the items which are available for the current event
        /// </summary>
        private void FillsListboxWithItemsForEvent()
        {
            lbMaterialRentProductsInList.Items.Clear();
            lbGereserveerdMateriaal.Items.Clear();
            dbConnection = new DataBaseConnection();
            MaterialRentCheckConnection = new MaterialRentInfo(dbConnection);
            ListMaterials = MaterialRentCheckConnection.GetMaterialsInEvent();
            foreach (Material material in ListMaterials)
            {
                lbMaterialRentProductsInList.Items.Add(material);
            }
            lbMaterialRentProductsInList.DisplayMember = "Name";

            RentedMaterial = dbConnection.GetReservedMaterial();
            foreach (Material M in RentedMaterial)
            {
                lbGereserveerdMateriaal.Items.Add(M.Name);
            }

        }

        #region attatchment
        /// <summary>
        /// Errormessage if the rfid errors
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void rfid_Error(object sender, Phidgets.Events.ErrorEventArgs e)
        {
            MessageBox.Show("Phidgets Error: " + e.Code + " : " + e.Description);
            if (!rfid.Attached)
            {
                btnReattach.Visible = true;
            }
            
        }
        /// <summary>
        /// This happens when you detach the RFID from the pc
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void rfid_Detach(object sender, Phidgets.Events.DetachEventArgs e)
        {

            MessageBox.Show("RFID is detached");
            //e.Device

        }

        void rfid_Attach(object sender, Phidgets.Events.AttachEventArgs e)
        {
            btnReattach.Visible = false;
            //Yay attatched :D
        }
        #endregion
        /// <summary>
        /// Reads the RFID tag 
        //  and displays the name of the user and his RFID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void rfid_Tag(object sender, Phidgets.Events.TagEventArgs e)
        {
            //lblRFID.Text = e.Tag;
            delayClean.Enabled = false;
            try
            {
                lblMaterialRentRfid.Text = MaterialRentInfoS.GetPersonalInfo(e.Tag).RFID;
                lblMaterialRentName.Text = MaterialRentInfoS.GetPersonalInfo(e.Tag).TotalName;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        void rfid_TagLost(object sender, Phidgets.Events.TagEventArgs e)
        {
            delayClean.Start();

            e.Tag.DefaultIfEmpty();

        }

        /// <summary>
        /// Reads the RFID 
        //  Selects the materials you want to rent
        //  Gets the material Id from the selected material 
        //  Also gets the startdate and the enddate
        //  enables and disables the right groupboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMaterialRentConfirm_Click(object sender, EventArgs e)
        {
            string CheckRfid = lblMaterialRentRfid.Text;
            Material CheckMaterial = (Material)lbMaterialRentProductsInList.SelectedItem;
            int MaterialId = CheckMaterial.MaterialId;
            DateTime Today = DateTime.Now;
            DateTime EndDate = dateTimePickerMaterialRentEndDate.Value;
            if(EndDate >= Today)
            {
                try
                {
                    MaterialRentInfoS.MakeRent(CheckRfid, Today, EndDate, MaterialId);
                    MessageBox.Show("Materiaal is uitgeleend.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                gbProducts.Enabled = true;
                gbRfidScan.Enabled = false;
                FillsListboxWithItemsForEvent();
                lblMaterialRentRfid.Text = "";
                lblMaterialRentName.Text = "";
            }
            else
            {
                MessageBox.Show("Verkeerde datum");
            }
           
            //this.Close();
        }
        /// <summary>
        ///  checks which material is selected and
        //   and shows the details of the selected items each time an item is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbMaterialRentProductsInList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Material MaterialSelected;
            MaterialSelected = (Material)lbMaterialRentProductsInList.SelectedItem;
            foreach (Material material in ListMaterials)
            {
                if (MaterialSelected == material)
                {
                    lbHereComeTheDetails.Text = material.Name;
                    lblHereComeTheRentCosts.Text = Convert.ToString(material.Rent);
                    lblHereComeTheStats.Text = material.State;
                }
            }

        }

        private void delayClean_Tick(object sender, EventArgs e)
        {
            delayClean.Enabled = false;
            //todo clean form
        }
        /// <summary>
        /// Enables and disables the right groupboxes to select an product and to 
        /// scan the RFID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirmItemRent_Click(object sender, EventArgs e)
        {
            gbRfidScan.Enabled = true;
            gbProducts.Enabled = false;
        }



    }
}
