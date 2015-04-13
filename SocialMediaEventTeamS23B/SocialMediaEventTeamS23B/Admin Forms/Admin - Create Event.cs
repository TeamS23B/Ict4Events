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
        Admin admin;
        List<Location> locations;
        List<Material> materials;
        List<Material> materialsInEvent;
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
        private void GetMaterialsInEvent()
        {
            lbMaterialOnLocation.Items.Clear();
            materialsInEvent = admin.GetMaterialsInEvent();
            foreach (Material ME in materialsInEvent)
            {
                lbMaterialOnLocation.Items.Add(ME.MaterialId + ": " + ME.Name);
            }
        }
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
                if(cbLocations.Items.ToString() == townSteet)
                {
                    EventLocation = L;
                }
            }
            DateTime startDate = new DateTime((int)nudStartYear.Value, (int)nudStartMonth.Value, (int)nudStartDay.Value);
            DateTime endDate = new DateTime((int)nudEndYear.Value, (int)nudEndMonth.Value, (int)nudEndDay.Value);
            admin.AddEvent(EventLocation, tbName.Text, startDate, endDate);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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
                    }
                }
            }
            catch
            {
                MessageBox.Show("Noting Selected");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Material ME in materialsInEvent)
                {
                    if (ME.MaterialId + ": " + ME.Name == lbMaterialOnLocation.SelectedItem.ToString())
                    {
                        lbAllMaterial.Items.Add(ME.MaterialId + ": " + ME.Name);
                        lbMaterialOnLocation.Items.Remove(ME.MaterialId + ": " + ME.Name);
                        materialsInEvent.Remove(ME);
                        admin.RemoveMaterialFromEvent(ME);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
