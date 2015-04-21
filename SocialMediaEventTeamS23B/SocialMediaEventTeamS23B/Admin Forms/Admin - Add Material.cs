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

namespace SocialMediaEventTeamS23B.Admin_Forms
{
    public partial class Admin___Add_Material : Form
    {
        List<Material> Materials;
        ApplicationLayer.Admin adm = new ApplicationLayer.Admin();
        public Admin___Add_Material()
        {
            InitializeComponent();
            btnEdit.Visible = false;
        }

        /// <summary>
        /// Reload materials into the listview.
        /// </summary>
        public void refreshListView()
        {
            lvMaterial.Items.Clear();
            Materials = adm.GetAllMaterials();
            foreach (Material material in Materials)
            {
                ListViewItem lvi = new ListViewItem(material.MaterialId.ToString());
                lvi.SubItems.Add(material.Type);
                lvi.SubItems.Add(material.Name);
                lvi.SubItems.Add(material.Price.ToString());
                lvi.SubItems.Add(material.State);
                lvMaterial.Items.Add(lvi);
            }
        }

        /// <summary>
        /// Open the form 'Admin - Add Material - Add'.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Admin___Add_Material___Add AdminAddMatAdd = new Admin___Add_Material___Add();
            AdminAddMatAdd.Show();
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
        /// Execute refreshListView upon opening of the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Admin___Add_Material_Load(object sender, EventArgs e)
        {
            refreshListView();
        }

        /// <summary>
        /// When the form is activated, refresh the listview.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Admin___Add_Material_Activated(object sender, EventArgs e)
        {
            refreshListView();
        }

        /// <summary>
        /// Remove the selected material.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            int matId = Convert.ToInt32(lvMaterial.SelectedIndices[0]);
            DialogResult dr = MessageBox.Show(String.Format("Weet u zeker dat u {0} {1} wilt verwijderen?", Materials.ElementAt(matId).Type, Materials.ElementAt(matId).Name), "Beheersysteem", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                adm.RemoveMaterial(Materials.ElementAt(matId));
                refreshListView();
            }
        }

    }
}
