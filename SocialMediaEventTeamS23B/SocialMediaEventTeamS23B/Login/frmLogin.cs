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
using DatabaseConnection;
using DatabaseConnection.Exeptions;

namespace SocialMediaEventTeamS23B
{
    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();
            dbConnetion=new DataBaseConnection();
            login=new Login(dbConnetion);
            MakeAllButtonsInvisible();
        }

        private Login login;
        private DataBaseConnection dbConnetion;

        private void MakeAllButtonsInvisible()
        {
            btnAccesControl.Visible = false;
            btnAdmin.Visible = false;
            btnMaterial.Visible = false;
            btnReserving.Visible = false;
            btnSocialMediaSharing.Visible = false;
            btnLogOut.Visible = false;
        }


        private enum Functions { Beheerder, Receptionist, Portier, Materiaalverhuur, User, NonUser, error, BeheerderUser, ReceptionistUser, PortierUser, MateriaalverhuurUser }

        private void btLogin_Click(object sender, EventArgs e)
        {
            Functions en;
            if (login.IsLoggedIn)
            {
                MessageBox.Show("User is al ingelogd");
            }
            try
            {
                en =
                    (Functions)
                        Enum.Parse(typeof (Functions), login.LoginToApplication(tbUsername.Text, tbPassword.Text));

            }
            catch (InvalidDataException iDataEx)
            {
                MessageBox.Show("Username of Password is niet correct!");
                return;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            switch (en)
            {
                case Functions.BeheerderUser:
                    AdminUserControl();
                    break;
                case Functions.PortierUser:
                    GuardUserControl();
                    break;
                case Functions.MateriaalverhuurUser:
                    MaterialRentUserControl();
                    break;
                case Functions.ReceptionistUser:
                    ReceptionistUserControl();
                    break;
                case Functions.Beheerder:
                    AdminControl();
                    break;
                case Functions.Portier:
                    AccesControl();
                    break;
                case Functions.Receptionist:
                    ReserveControl();
                    break;
                case Functions.Materiaalverhuur:
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
            btnLogOut.Visible = true;
            lblLoggedIn.Text = "U bent ingelogd";
        }

        private void MaterialRentUserControl()
        {
            btnMaterial.Visible = true;
            btnSocialMediaSharing.Visible = true;
            btnLogOut.Visible = true;
            lblLoggedIn.Text = "U bent ingelogd";

        }

        private void GuardUserControl()
        {
            btnAccesControl.Visible = true;
            btnSocialMediaSharing.Visible = true;
            btnLogOut.Visible = true;
            lblLoggedIn.Text = "Logged in";

        }

        private void AdminUserControl()
        {
            btnAdmin.Visible = true;
            btnAccesControl.Visible = true;
            btnMaterial.Visible = true;
            btnReserving.Visible = true;
            btnSocialMediaSharing.Visible = true;
            btnLogOut.Visible = true;
            lblLoggedIn.Text = "Logged in";

        }

        private void NonUserControl()
        {
            MessageBox.Show("Dit is geen gebruiker");
            lblLoggedIn.Text = "Not logged in";

        }

        private void UserControl()
        {
            btnSocialMediaSharing.Visible = true;
            btnLogOut.Visible = true;
            lblLoggedIn.Text = "Logged in";

        }

        private void MaterialControl()
        {
            btnMaterial.Visible = true;
            btnLogOut.Visible = true;
            lblLoggedIn.Text = "Logged in";

        }

        private void ReserveControl()
        {
            btnReserving.Visible = true;
            btnLogOut.Visible = true;
            lblLoggedIn.Text = "Logged in";

        }

        private void AccesControl()
        {
            btnAccesControl.Visible = true;
            btnLogOut.Visible = true;
            lblLoggedIn.Text = "Logged in";

        }

        private void AdminControl()
        {
            btnAdmin.Visible = true;
            btnAccesControl.Visible = true;
            btnMaterial.Visible = true;
            btnReserving.Visible = true;
            btnLogOut.Visible = true;
            lblLoggedIn.Text = "Logged in";

        }

        private void btnAccesControl_Click_1(object sender, EventArgs e)
        {
            AccessControl AccesControlForm = new AccessControl(dbConnetion);
            AccesControlForm.Show();
        }

        private void btnSocialMediaSharing_Click(object sender, EventArgs e)
        {

        }

        private void btnMaterial_Click(object sender, EventArgs e)
        {
            MaterialRent MaterialRent = new MaterialRent(dbConnetion);
            MaterialRent.Show();
        }

        private void btnReserving_Click(object sender, EventArgs e)
        {
            ReservationDetails ReservationForm = new ReservationDetails(dbConnetion);
            ReservationForm.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Admin_Forms.Admin___Menu AdminMenu = new Admin_Forms.Admin___Menu(dbConnetion);
            AdminMenu.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            MakeAllButtonsInvisible();
            login.LogoutFromApplication();
            btnLogOut.Visible = false;
            tbPassword.Clear();
            tbUsername.Clear();
        }
    }
}
