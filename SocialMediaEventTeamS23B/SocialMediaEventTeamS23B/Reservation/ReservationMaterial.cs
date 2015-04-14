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

namespace SocialMediaEventTeamS23B
{
    public partial class ReservationMaterial : Form
    {
        Visitor leader;
        List<Visitor> members = new List<Visitor>();
        List<MapLocation> maplocations;
        List<Material> materialToReserve = new List<Material>();

        ApplicationLayer.Reservations res;
        private List<Material> materials;//beschikbaar materiaal
        private List<Material> reservedMatrials;//gereserveerdmaterial
        public ReservationMaterial(Visitor leader, List<Visitor> members, List<MapLocation> maplocations)
        {
            InitializeComponent();
            this.leader = leader;
            this.members = members;
            this.maplocations = maplocations;
            res = new Reservations();
            materials = new List<Material>();
            reservedMatrials = new List<Material>();
            FillList();
        }
        private void FillList()
        {
            materials = res.GetEventMatrial();
            reservedMatrials = res.GetReservedEventMatrial();
            foreach (Material M in materials)
            {  
                int countTrue = 0;
                foreach(Material RM in reservedMatrials)
                {
                    
                    if(M.MaterialId == RM.MaterialId)
                    {
                        countTrue++;
                    }
                }
                if(countTrue == 0)
                {
                    lbReservationNotReserved.Items.Add(M.MaterialId + ": " + M.Name);
                }
            }
        }

        private void btnReservationMaterialNext_Click(object sender, EventArgs e)
        {
            ReservationConfirmation ResConfirmation = new ReservationConfirmation(leader, members, maplocations, materialToReserve);
            ResConfirmation.Show();
        }

        private void btnReservationMaterialPrevious_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btnReservationAddMaterial_Click(object sender, EventArgs e)
        {
            try
            {
                foreach(Material M in materials)
                {
                    if (lbReservationNotReserved.SelectedItem.ToString() == M.MaterialId + ": " + M.Name)
                    {
                        lbReservationReserved.Items.Add(M.MaterialId + ": " + M.Name);
                        lbReservationNotReserved.Items.Remove(M.MaterialId + ": " + M.Name);
                        materialToReserve.Add(M);
                    }
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReservationRemoveMaterial_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Material M in materials)
                {
                    if (lbReservationNotReserved.SelectedItem.ToString() == M.MaterialId + ": " + M.Name)
                    {
                        lbReservationNotReserved.Items.Add(M.MaterialId + ": " + M.Name);
                        lbReservationReserved.Items.Remove(M.MaterialId + ": " + M.Name);
                        materialToReserve.Remove(M);
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
