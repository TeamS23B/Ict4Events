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

        
        private enum Functions { Admin, Receptionist, Guard, MaterialRent, User, NonUser, error,AdminUser, ReceptionistUser,GuardUser,MaterialRentUser}

        private void btLogin_Click(object sender, EventArgs e)
        {
            Login Login = new Login(tbUsername.Text, tbPassword.Text);
            /*if(Login.SendToDatabase(tbUsername.Text, tbPassword.Text)=="User")
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
            }*/

            var en= (Functions)Enum.Parse(typeof(Functions), Login.SendToDatabase(tbUsername.Text, tbPassword.Text));

            switch (en)
            {
                case Functions.AdminUser:
                    AdminUserControl();
                    break;
                case Functions.GuardUser:
                    GuardUserControl();
                    break;
                case Functions.MaterialRentUser:
                    MaterialRentUserControl();
                    break;
                case Functions.ReceptionistUser:
                    ReceptionistUserControl();
                    break;
                case Functions.Admin:
                    AdminstratieMachtiging();
                    break;
                case Functions.Guard:
                    AccesControl();
                    break;
                case Functions.Receptionist:
                    ReserveControl();
                    break;
                case Functions.MaterialRent:
                    MaterialControl();
                    break;
                case Functions.User:
                    UserControl();
                    break;
                case Functions.NonUser:
                    NonUserControl();
                    break;
                case Functions.error:
                    NonUserControl();
                    break;               
                default:
                    NonUserControl();
                    break;
            }
        }

        private void ReceptionistUserControl()
        {
            btnReserving.Visible = true;
            btnSocialMediaSharing.Visible = true;
        }

        private void MaterialRentUserControl()
        {
            btnMaterial.Visible = true;
            btnSocialMediaSharing.Visible = true;
        }

        private void GuardUserControl()
        {
            btnAccesControl.Visible = true;
            btnSocialMediaSharing.Visible = true;
        }

        private void AdminUserControl()
        {
            btnAdmin.Visible = true;
            btnAccesControl.Visible = true;
            btnMaterial.Visible = true;
            btnReserving.Visible = true;
            btnSocialMediaSharing.Visible = true;
        }

        private static void NonUserControl()
        {
            MessageBox.Show("Dit is geen gebruiker");
        }

        private void UserControl()
        {
            btnSocialMediaSharing.Visible = true;
        }

        private void MaterialControl()
        {
            btnMaterial.Visible = true;
        }

        private void ReserveControl()
        {
            btnReserving.Visible = true;
        }

        private void AccesControl()
        {
            btnAccesControl.Visible = true;
        }

        private void AdminstratieMachtiging()
        {
            btnAdmin.Visible = true;
            btnAccesControl.Visible = true;
            btnMaterial.Visible = true;
            btnReserving.Visible = true;
        }

        private void btnAccesControl_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAccesControl_Click_1(object sender, EventArgs e)
        {
            AccessControl AccesControlForm = new AccessControl();
            AccesControlForm.Show();
        }

        private void btnSocialMediaSharing_Click(object sender, EventArgs e)
        {
           
        }

        private void btnMaterial_Click(object sender, EventArgs e)
        {
            MaterialRent MaterialRent = new MaterialRent();
            MaterialRent.Show();
        }

        private void btnReserving_Click(object sender, EventArgs e)
        {
            ReservationDetails ReservationForm = new ReservationDetails();
            ReservationForm.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {

        }
    }
}
