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
using ApplicationLayer;

namespace SocialMediaEventTeamS23B
{
    public partial class ReservationConfirmation : Form
    {
        Visitor leader;
        List<Visitor> members = new List<Visitor>();
        MapLocation maplocation;
        List<Material> toReserve = new List<Material>();

        ApplicationLayer.Reservations res;
        public ReservationConfirmation(Visitor leader, List<Visitor> members, MapLocation maplocation, List<Material> toReserve)
        {
            InitializeComponent();
            this.leader = leader;
            this.members = members;
            this.maplocation = maplocation;
            this.toReserve = toReserve;
            res = new Reservations();
            members = new List<Visitor>();
            GetData();
        }
        private void GetData()
        {
            
        }

        private void btnReservationConfirmationNext_Click(object sender, EventArgs e)
        {

            //sent alles close alls
        }

        private void btnReservationConfirmationPrevious_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
