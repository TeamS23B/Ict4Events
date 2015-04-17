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
        /// <summary>
        /// Gets all the materials which are reserved for the event
        /// </summary>
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

        /// <summary>
        ///  shows the confirmation of the reservation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReservationMaterialNext_Click(object sender, EventArgs e)
        {
            ReservationConfirmation ResConfirmation = new ReservationConfirmation(leader, members, maplocations, materialToReserve);
            ResConfirmation.Show();
        }

        /// <summary>
        /// Closes the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReservationMaterialPrevious_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
        /// <summary>
        /// Adds materials to the reservation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReservationAddMaterial_Click(object sender, EventArgs e)
        {
            try
            {
                foreach(Material M in materials)
                {
                    if (!string.IsNullOrEmpty(lbReservationNotReserved.SelectedItem.ToString()))
                    {
                    if (lbReservationNotReserved.SelectedItem.ToString() == M.MaterialId + ": " + M.Name)
                    {
                        lbReservationReserved.Items.Add(M.MaterialId + ": " + M.Name);
                        lbReservationNotReserved.Items.Remove(M.MaterialId + ": " + M.Name);
                        materialToReserve.Add(M);
                            break;
                        }
                    }
                }
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        /// <summary>
        /// deletes reserved items from the reserved list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReservationRemoveMaterial_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Material M in materials)
                {
                    if (lbReservationReserved.SelectedItem.ToString() == M.MaterialId + ": " + M.Name)
                    {
                        lbReservationNotReserved.Items.Add(M.MaterialId + ": " + M.Name);
                        lbReservationReserved.Items.Remove(M.MaterialId + ": " + M.Name);
                        materialToReserve.Remove(M);
                        break;
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
