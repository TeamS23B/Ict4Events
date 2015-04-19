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
using DatabaseConnection.Exceptions;
using SocialMediaEventTeamS23B.SMSForms;

namespace SocialMediaEventTeamS23B
{
    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();
            dbConnection = new DataBaseConnection();
            login = new Login(dbConnection);
            MakeAllButtonsInvisible();
        }

        private Login login;
        private DataBaseConnection dbConnection;

        /// <summary>
        /// Makes all buttons invisible except the login button
        /// </summary>
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

        /// <summary>
        /// Creates a hash password and checks if the username and password is correct and gives the user permissions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btLogin_Click(object sender, EventArgs e)
        {
            Functions en;
            if (login.IsLoggedIn)
            {
                MessageBox.Show("User is al ingelogd");
            }
            try
            {
                Console.WriteLine(tbPassword.Text);
                var pwHash = Login.HashedBytes(Encoding.ASCII.GetBytes(tbPassword.Text));
                Console.WriteLine(BitConverter.ToString(pwHash));
                
                Console.WriteLine(BitConverter.ToString(pwHash));
                
                en =
                    (Functions)
                        Enum.Parse(typeof(Functions), login.LoginToApplication(tbUsername.Text, BitConverter.ToString(pwHash)));

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

        /// <summary>
        /// The next methods open certain buttons, dependant on the permissions the user has
        /// </summary>
        private void ReceptionistUserControl()
        {
            btnReserving.Visible = true;
            btnSocialMediaSharing.Visible = true;
            btnLogOut.Visible = true;
            lblLoggedIn.Text = "U bent ingelogd";
            AfterLoggingInVisibles();
        }

        private void AfterLoggingInVisibles()
        {
            btLogin.Visible = false;
            lblUsername.Visible = false;
            lblPassword.Visible = false;
            tbPassword.Visible = false;
            tbUsername.Visible = false;
        }

        private void MaterialRentUserControl()
        {
            btnMaterial.Visible = true;
            btnSocialMediaSharing.Visible = true;
            btnLogOut.Visible = true;
            lblLoggedIn.Text = "U bent ingelogd";
            AfterLoggingInVisibles();
        }

        private void GuardUserControl()
        {
            btnAccesControl.Visible = true;
            btnSocialMediaSharing.Visible = true;
            btnLogOut.Visible = true;
            lblLoggedIn.Text = "U bent ingelogd";
            AfterLoggingInVisibles();
        }

        private void AdminUserControl()
        {
            btnAdmin.Visible = true;
            btnAccesControl.Visible = true;
            btnMaterial.Visible = true;
            btnReserving.Visible = true;
            btnSocialMediaSharing.Visible = true;
            btnLogOut.Visible = true;
            lblLoggedIn.Text = "U bent ingelogd";
            AfterLoggingInVisibles();
        }

        private void NonUserControl()
        {
            MessageBox.Show("Dit is geen gebruiker");
            lblLoggedIn.Text = "U bent niet ingelogd";

        }

        private void UserControl()
        {
            btnSocialMediaSharing.Visible = true;
            btnLogOut.Visible = true;
            lblLoggedIn.Text = "U bent ingelogd";
            AfterLoggingInVisibles();
        }

        private void MaterialControl()
        {
            btnMaterial.Visible = true;
            btnLogOut.Visible = true;
            lblLoggedIn.Text = "U bent ingelogd";
            AfterLoggingInVisibles();
        }

        private void ReserveControl()
        {
            btnReserving.Visible = true;
            btnLogOut.Visible = true;
            lblLoggedIn.Text = "U bent ingelogd";
            AfterLoggingInVisibles();
        }

        private void AccesControl()
        {
            btnAccesControl.Visible = true;
            btnLogOut.Visible = true;
            lblLoggedIn.Text = "U bent ingelogd";
            AfterLoggingInVisibles();
        }

        private void AdminControl()
        {
            btnAdmin.Visible = true;
            btnAccesControl.Visible = true;
            btnMaterial.Visible = true;
            btnReserving.Visible = true;
            btnLogOut.Visible = true;
            lblLoggedIn.Text = "U bent ingelogd";
            AfterLoggingInVisibles();
        }

        /// <summary>
        /// Opens accescontrolform
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAccesControl_Click_1(object sender, EventArgs e)
        {
            AccessControl AccesControlForm = new AccessControl(dbConnection);
            AccesControlForm.Show();
        }
        /// <summary>
        /// Opens SocialMediaMainForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSocialMediaSharing_Click(object sender, EventArgs e)
        {
            SMSMain smsMainForm = new SMSMain(dbConnection, login.GetVisitor());
            smsMainForm.Show();
        }
        /// <summary>
        /// Opens MaterialRent form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMaterial_Click(object sender, EventArgs e)
        {
            MaterialRent MaterialRent = new MaterialRent(dbConnection);
            MaterialRent.Show();
        }
        /// <summary>
        /// Opens reservationform
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReserving_Click(object sender, EventArgs e)
        {
            ReservationDetails ReservationForm = new ReservationDetails(null, null);
            ReservationForm.Show();
        }
        /// <summary>
        /// shows admin form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Admin_Forms.Admin___Menu AdminMenu = new Admin_Forms.Admin___Menu(dbConnection);
            AdminMenu.Show();
        }
        /// <summary>
        /// Clears the usernametextbox and the passwordtextbox and enables certain labels and buttons 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            MakeAllButtonsInvisible();
            login.LogoutFromApplication();
            btnLogOut.Visible = false;
            tbPassword.Clear();
            tbUsername.Clear();
            lblLoggedIn.Text = "U bent uitgelogd";
            btLogin.Visible = true;
            lblUsername.Visible = true;
            lblPassword.Visible = true;
            tbPassword.Visible = true;
            tbUsername.Visible = true;

        }
    }
}
