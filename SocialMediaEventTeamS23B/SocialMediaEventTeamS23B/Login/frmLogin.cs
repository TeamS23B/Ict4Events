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

namespace SocialMediaEventTeamS23B
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            MaakAlleButtonsOntzichtbaar();
        }

        private void MaakAlleButtonsOntzichtbaar()
        {
            btnAccesControl.Visible = false;
            btnAdmin.Visible = false;
            btnMaterial.Visible = false;
            btnReserving.Visible = false;
            btnSocialMediaSharing.Visible = false;
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string[] ArrayFuncties = new string[3];
            ArrayFuncties[0] = "Beheerder";
            ArrayFuncties[1] = "Receptionist";
            ArrayFuncties[2] = "Portier";
            ArrayFuncties[3] = "Materiaalverhuur";
            Login Login = new Login(tbUsername.Text, tbPassword.Text);
            if(Login.SendToDatabase(tbUsername.Text, tbPassword.Text)=="User")
            {
                btnSocialMediaSharing.Visible = true;
            }
            else if(Login.SendToDatabase(tbUsername.Text, tbPassword.Text)=="NonUser")
            {
                MessageBox.Show("Dit is geen gebruiker");
            }
            else if(ArrayFuncties.Contains(Login.SendToDatabase(tbUsername.Text, tbPassword.Text)))
            {
                btnAdmin.Visible = true;
                btnAccesControl.Visible = true;
                btnSocialMediaSharing.Visible = true;
                btnMaterial.Visible = true;
                btnReserving.Visible = true;
            }
        }
    }
}
