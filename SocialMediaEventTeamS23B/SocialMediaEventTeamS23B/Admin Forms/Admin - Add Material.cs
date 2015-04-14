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
        }

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Admin___Add_Material___Add AdminAddMatAdd = new Admin___Add_Material___Add();
            AdminAddMatAdd.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Admin___Add_Material_Load(object sender, EventArgs e)
        {
            refreshListView();
        }

        private void Admin___Add_Material_Activated(object sender, EventArgs e)
        {
            refreshListView();
        }

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
