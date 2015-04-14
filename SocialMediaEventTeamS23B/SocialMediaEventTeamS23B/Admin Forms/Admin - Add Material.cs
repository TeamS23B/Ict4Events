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
        ApplicationLayer.Admin adm = new ApplicationLayer.Admin();
        public Admin___Add_Material()
        {
            InitializeComponent();
        }

        public void refreshListView()
        {
            lvMaterial.Items.Clear();
            List<Material> materials = adm.GetAllMaterials();
            foreach (Material material in materials)
            {
                ListViewItem lvi = new ListViewItem(material.Type);
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

    }
}
