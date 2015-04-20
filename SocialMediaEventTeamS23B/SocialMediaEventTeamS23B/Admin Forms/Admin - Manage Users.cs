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

namespace SocialMediaEventTeamS23B.Beheer_Forms
{
    public partial class Beheer___Gebruikers_Beheren : Form
    {
        private Admin admin;
        private List<Visitor> visitors;
        private List<Post> posts;
        private List<Material> materials;
        private Visitor SelectedVisitor;
        private Post SelectedPost;

        /// <summary>
        /// Constructor.
        /// </summary>
        public Beheer___Gebruikers_Beheren()
        {
            InitializeComponent();
            admin = new Admin();
            visitors = new List<Visitor>();
            posts = new List<Post>();
            materials = new List<Material>();
            AddVisitors();
            FillLists();
        }

        /// <summary>
        /// Fill the materials list with all available materials.
        /// </summary>
        private void FillLists()
        {
            
            materials = admin.GetAllMaterials();
        }

        /// <summary>
        /// Fill lbVisitors with every registered visitor.
        /// </summary>
        private void AddVisitors()
        {
            lbVisitors.Items.Clear();
            visitors = admin.GetVisitors();
            foreach (Visitor V in visitors)
            {
                lbVisitors.Items.Add(V.RFID + ": " + V.Name);
            }
        }

        /// <summary>
        /// When cbMessageVisible is checked, the selected post will become invisible.
        /// When unchecked, the post becomes visible.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (lbMessages.SelectedItem.ToString() == "Title: " + SelectedPost.Title + " | " + SelectedPost.PostedOn)
                {
                    if (cbMessageVisible.CheckState.ToString() == "Checked")
                    {
                        admin.EditPost(SelectedVisitor, SelectedPost.Title, 3);
                        MessageBox.Show("Bericht is nu onzichtbaar.");
                        
                    }
                    else if (cbMessageVisible.CheckState.ToString() == "Unchecked")
                    {
                        admin.EditPost(SelectedVisitor, SelectedPost.Title, 4);
                        MessageBox.Show("Bericht is nu zichtbaar.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void Beheer___Gebruikers_Beheren_Click(object sender, EventArgs e)
        {


        }

        /// <summary>
        /// Fill the messages listbox with posts related to the selected user.
        /// </summary>
        /// <param name="v"></param>
        private void FillPosts(Visitor v)
        {
            foreach (Post P in posts)
            {
                if (SelectedVisitor.RFID == P.Uploader)
                {
                    lbMessages.Items.Clear();
                    lbMessages.Items.Add(P);
                }
            }
        }

        /// <summary>
        /// Fill the materials listbox with materials rented by the selected visitor.
        /// </summary>
        /// <param name="v"></param>
        private void FillMaterials(Visitor v)
        {
            materials = admin.VisitorMaterial(v);
            foreach (Material M in materials)
            {
                lbMaterials.Items.Add(M.MaterialId + ": " + M.Name);
            }
        }

        /// <summary>
        /// When cbUserBlocked is checked, the currently selected user will be blocked from the system.
        /// When unchecked, the block is lifted.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbUserBlocked_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (lbVisitors.SelectedItem.ToString() == SelectedVisitor.RFID + ": " + SelectedVisitor.Name)
                {
                    if (cbUserBlocked.CheckState.ToString() == "Checked")
                    {
                        admin.EditVisitor(SelectedVisitor, 1);
                        MessageBox.Show("Gebruiker is geblokkeerd.");
                    }
                    else if (cbUserBlocked.CheckState.ToString() == "Unchecked")
                    {
                        admin.EditVisitor(SelectedVisitor, 2);
                        MessageBox.Show("Blokkering opgeheven.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// When the selected index of lbVisitors changes, posts related to the selected user are loaded into the form,
        /// along with the reserved materials. 'SelectedVisitor' is set to the selected item index.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbVisitors_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Visitor V in visitors)
            {
                if (lbVisitors.SelectedItem.ToString() == V.RFID + ": " + V.Name)
                {
                    cbUserBlocked.Enabled = true;
                    cbMessageVisible.Enabled = false;
                    lbMessages.ClearSelected();
                    lbMessages.Items.Clear();
                    lbMaterials.Items.Clear();
                    SelectedVisitor = V;
                    posts = admin.GetPosts(V.Username);
                    FillPosts(V);
                    FillMaterials(V);
                }
            }
        }

        /// <summary>
        /// When the selected index of lbMessages changes, 'SelectedPost' is set to the current item index.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbMessages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbMessages.SelectedIndex != -1)
            {
                foreach (Post P in posts)
                {
                    if (lbMessages.SelectedItem.ToString() == "Title: " + P.Title + " | " + P.PostedOn)
                    {
                        cbMessageVisible.Enabled = true;
                        SelectedPost = P;
                        

                    }
                }
            }
            
        }
    }
}
