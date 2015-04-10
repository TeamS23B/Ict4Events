using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocialMediaEventTeamS23B.Admin_Forms
{
    public partial class Admin___Add_Material : Form
    {
        public Admin___Add_Material()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Admin___Add_Material___Add AdminAddMatAdd = new Admin___Add_Material___Add();
            AdminAddMatAdd.Show();
        }
    }
}
