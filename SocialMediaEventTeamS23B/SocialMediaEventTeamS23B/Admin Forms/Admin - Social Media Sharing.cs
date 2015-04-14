using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApplicationLayer;

namespace SocialMediaEventTeamS23B.Admin_Forms
{
    public partial class Admin___Social_Media_Sharing : Form
    {
        private Admin admin;
        public Admin___Social_Media_Sharing()
        {
            InitializeComponent();
            admin = new Admin();
        }

        private void lblAllMessages_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveFilter_Click(object sender, EventArgs e)
        {
            admin.EditFlaggingControl((int)nudFlags.Value, (int)nudRatio.Value, (int)nudTime.Value, cbAutoFilter.Checked);
            MessageBox.Show("Settings saved!");
        }
    }
}
