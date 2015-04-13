using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseConnection;

namespace SocialMediaEventTeamS23B.Admin_Forms
{
    public partial class Admin___Menu : Form
    {
        public Admin___Menu(DataBaseConnection dbc)
        {
            InitializeComponent();
        }

        private void btnAdminAddMaterial_Click(object sender, EventArgs e)
        {
            Admin___Add_Material AdminAddMaterial = new Admin___Add_Material();
            AdminAddMaterial.Show();
        }

        private void btnAdminCreateEvent_Click(object sender, EventArgs e)
        {
            Beheer_Forms.Beheer___Event_Aanmaken AdminCreateEvent = new Beheer_Forms.Beheer___Event_Aanmaken();
            AdminCreateEvent.Show();
        }

        private void btnAdminManageUsers_Click(object sender, EventArgs e)
        {
            Beheer_Forms.Beheer___Gebruikers_Beheren AdminManageUsers = new Beheer_Forms.Beheer___Gebruikers_Beheren();
            AdminManageUsers.Show();
        }

        private void btnAdminSocialMediaSharing_Click(object sender, EventArgs e)
        {
            Admin___Social_Media_Sharing AdminSocialMediaSharing = new Admin___Social_Media_Sharing();
            AdminSocialMediaSharing.Show();
        }
    }
}
