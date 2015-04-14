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

namespace SocialMediaEventTeamS23B
{
    public partial class ReservationMaterial : Form
    {
        private List<Material> materials;
        public ReservationMaterial()
        {
            InitializeComponent();
            materials = new List<Material>();
            FillList();
        }
        private void FillList()
        {

        }

        private void btnReservationMaterialNext_Click(object sender, EventArgs e)
        {
            ReservationConfirmation ResConfirmation = new ReservationConfirmation();
            ResConfirmation.Show();
        }

        private void btnReservationMaterialPrevious_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
