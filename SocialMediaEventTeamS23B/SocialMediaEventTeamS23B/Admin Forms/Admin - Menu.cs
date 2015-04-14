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

        /// <summary>
        /// Open the Add Material form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdminAddMaterial_Click(object sender, EventArgs e)
        {
            Admin___Add_Material AdminAddMaterial = new Admin___Add_Material();
            AdminAddMaterial.Show();
        }

        /// <summary>
        /// Open the Create Event form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdminCreateEvent_Click(object sender, EventArgs e)
        {
            Beheer_Forms.Beheer___Event_Aanmaken AdminCreateEvent = new Beheer_Forms.Beheer___Event_Aanmaken();
            AdminCreateEvent.Show();
        }

        /// <summary>
        /// Open the Manage Users form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdminManageUsers_Click(object sender, EventArgs e)
        {
            Beheer_Forms.Beheer___Gebruikers_Beheren AdminManageUsers = new Beheer_Forms.Beheer___Gebruikers_Beheren();
            AdminManageUsers.Show();
        }

        /// <summary>
        /// Open the Social Media Sharing form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdminSocialMediaSharing_Click(object sender, EventArgs e)
        {
            Admin___Social_Media_Sharing AdminSocialMediaSharing = new Admin___Social_Media_Sharing();
            AdminSocialMediaSharing.Show();
        }
    }
}
