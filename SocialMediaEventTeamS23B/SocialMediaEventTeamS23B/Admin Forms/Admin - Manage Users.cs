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
        private void FillLists()
        {
            //posts = admin.GetPosts();
            materials = admin.GetAllMaterials();
        }

        private void AddVisitors()
        {
            lbVisitors.Items.Clear();
            visitors = admin.GetVisitors();
            foreach (Visitor V in visitors)
            {
                lbVisitors.Items.Add(V.RFID + ": " + V.Name);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (lbVisitors.SelectedItem.ToString() == SelectedVisitor.RFID + ": " + SelectedVisitor.Name)
                {
                    if (cbMessageVisible.CheckState.ToString() == "Checked")
                    {
                        admin.EditVisitor(SelectedVisitor, 3);
                    }
                    else if (cbMessageVisible.CheckState.ToString() == "Unchecked")
                    {
                        admin.EditVisitor(SelectedVisitor, 4);
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Beheer___Gebruikers_Beheren_Click(object sender, EventArgs e)
        {


        }
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
        private void FillMaterials(Visitor v)
        {
            materials = admin.VisitorMaterial(v);
            foreach (Material M in materials)
            {
                lbMaterials.Items.Add(M.MaterialId + ": " + M.Name);
            }
        }

        private void cbUserBlocked_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (lbVisitors.SelectedItem.ToString() == SelectedVisitor.RFID + ": " + SelectedVisitor.Name)
                {
                    if (cbMessageVisible.CheckState.ToString() == "Checked")
                    {
                        admin.EditVisitor(SelectedVisitor, 1);
                    }
                    else if (cbMessageVisible.CheckState.ToString() == "Unchecked")
                    {
                        admin.EditVisitor(SelectedVisitor, 2);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbVisitors_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Visitor V in visitors)
            {
                if (lbVisitors.SelectedItem.ToString() == V.RFID + ": " + V.Name)
                {
                    lbMessages.Items.Clear();
                    lbMaterials.Items.Clear();
                    SelectedVisitor = V;
                    posts = admin.GetPosts(V.Username);
                    FillPosts(V);
                    FillMaterials(V);
                }
            }
        }
    }
}
