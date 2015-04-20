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
using ApplicationLayer.Exceptions;

namespace SocialMediaEventTeamS23B.Beheer_Forms
{
    public partial class Beheer___Event_Aanmaken : Form
    {
        private Admin admin;
        private List<Location> locations;
        private List<Material> materials;
        private List<Material> materialsInEvent;
        public Beheer___Event_Aanmaken()
        {
            InitializeComponent();
            admin = new Admin();
            locations = new List<Location>(); 
            materials = new List<Material>();
            materialsInEvent = new List<Material>();
            GetLocations();
            GetMaterialsInEvent();
            GetMaterials();
            
        }

        /// <summary>
        /// Add materials available at the event to lbMaterialOnLocation.
        /// </summary>
        private void GetMaterialsInEvent()
        {
            lbMaterialOnLocation.Items.Clear();
            materialsInEvent = admin.GetMaterialsInEvent();
            foreach (Material ME in materialsInEvent)
            {
                lbMaterialOnLocation.Items.Add(ME.MaterialId + ": " + ME.Name);
            }
        }

        /// <summary>
        /// Add all materials to lbAllMaterial.
        /// </summary>
        private void GetMaterials()
        {
            lbAllMaterial.Items.Clear();
            materials = admin.GetAllMaterials();
            foreach (Material M in materials)
            {
                int countTrue = 0;
                foreach(Material ME in materialsInEvent)
                {
                    if(M.MaterialId == ME.MaterialId)
                    {
                        countTrue++;
                    }
                }
                if(countTrue == 0)
                {
                    lbAllMaterial.Items.Add(M.MaterialId + ": " + M.Name);
                }              
            }
        }

        /// <summary>
        /// Retrieve all reservable locations and insert them into cbLocations.
        /// </summary>
        private void GetLocations()
        {
            cbLocations.Items.Clear();
            locations = admin.GetLocations();
            foreach(Location L in locations)
            {
                cbLocations.Items.Add(L.Town +" "+ L.Street);
            }          
        }

        /// <summary>
        /// Create an event according to the given parameters.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            Location EventLocation = null;
            foreach(Location L in locations)
            {
                string townSteet = L.Town +" "+ L.Street;
                if(cbLocations.Text == townSteet)
                {
                    EventLocation = L;
                }
            }
            DateTime startDate = new DateTime((int)nudStartYear.Value, (int)nudStartMonth.Value, (int)nudStartDay.Value);
            DateTime endDate = new DateTime((int)nudEndYear.Value, (int)nudEndMonth.Value, (int)nudEndDay.Value);
            admin.AddEvent(EventLocation, tbName.Text, startDate, endDate);
            MessageBox.Show("Event toegevoegd!");
        }

        /// <summary>
        /// Close the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Adds available material to the event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                foreach(Material M in materials)
                {
                    if(M.MaterialId + ": " + M.Name == lbAllMaterial.SelectedItem.ToString())
                    {
                        lbMaterialOnLocation.Items.Add(M.MaterialId + ": " + M.Name);
                        lbAllMaterial.Items.Remove(M.MaterialId + ": " + M.Name);
                        materialsInEvent.Add(M);
                        admin.AddMaterialToEvent(M);
                        break;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Nothing Selected");
            }
        }

        /// <summary>
        /// Removes materials from the event and returns them to the 'material pool'.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                Material RemoveMaterial = null;
                foreach (Material ME in materialsInEvent)
                {
                    
                    if (ME.MaterialId + ": " + ME.Name == lbMaterialOnLocation.SelectedItem.ToString())
                    {
                        lbAllMaterial.Items.Add(ME.MaterialId + ": " + ME.Name);
                        lbMaterialOnLocation.Items.Remove(ME.MaterialId + ": " + ME.Name);
                        RemoveMaterial = ME;
                        admin.RemoveMaterialFromEvent(ME);
                        break;
                    }
                }
                materialsInEvent.Remove(RemoveMaterial);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nothing Selected");
            }
        }
    }
}
