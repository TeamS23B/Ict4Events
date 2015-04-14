using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocialMediaEventTeamS23B
{
    public partial class ReservationLocation : Form
    {
        public ReservationLocation()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnReservationLocationNext_Click(object sender, EventArgs e)
        {
            ReservationMaterial ResMaterial = new ReservationMaterial();
            ResMaterial.Show();
        }
    }
}
