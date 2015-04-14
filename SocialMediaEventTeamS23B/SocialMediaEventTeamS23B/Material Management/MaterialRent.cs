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
        public MaterialRent(DataBaseConnection dbc)
        {
            InitializeComponent();
            gbRfidScan.Enabled = false;
            FillsListboxWithItemsForEvent();
            rfid = new RFID();
            rfid.open();

            rfid.Attach += rfid_Attach;
            rfid.Detach += rfid_Detach;
            rfid.Error += rfid_Error;

            rfid.Tag += rfid_Tag;
            rfid.TagLost += rfid_TagLost;
        }

        private void FillsListboxWithItemsForEvent()
        {
            dbConnection = new DataBaseConnection();
            MaterialRentCheckConnection = new MaterialRentInfo(dbConnection);
            ListMaterials = MaterialRentCheckConnection.GetMaterialsInEvent();
            foreach (Material material in ListMaterials)
            {
                lbMaterialRentProductsInList.Items.Add(material);
            }
            lbMaterialRentProductsInList.DisplayMember = "Name";
        }

        #region attatchment

        void rfid_Error(object sender, Phidgets.Events.ErrorEventArgs e)
        {
            MessageBox.Show("Phidgets Error: " + e.Code + " : " + e.Description);
            if (!rfid.Attached)
            {
                btnReattach.Visible = true;
            }
        }

        void rfid_Detach(object sender, Phidgets.Events.DetachEventArgs e)
        {
            //retry attachment
            e.Device.waitForAttachment(10000);
        }

        void rfid_Attach(object sender, Phidgets.Events.AttachEventArgs e)
        {
            btnReattach.Visible = false;
            //Yay attatched :D
        }
        private void btReattatch_Click(object sender, EventArgs e)
        {
            rfid.waitForAttachment(10000);
        }
        #endregion

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
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            delayClean.Stop();
        }
        private void btnMaterialRentConfirm_Click(object sender, EventArgs e)
        {

        }
        private void lbMaterialRentProductsInList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Material MaterialSelected;
            MaterialSelected = (Material)lbMaterialRentProductsInList.SelectedItem;
            foreach (Material material in ListMaterials)
            {
                if (MaterialSelected == material)
                {
                    lbHereComeTheDetails.Text = material.Name;
                    lblHereComeTheRentCosts.Text = Convert.ToString(material.Price);
                    lblHereComeTheStats.Text = material.State;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gbRfidScan.Enabled = false;
            
            Material SelectedMaterial =(Material)lbMaterialRentProductsInList.SelectedItem;


        }



    }
}
