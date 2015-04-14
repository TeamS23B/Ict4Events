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
        List<MapLocation> maplocations;
        List<Material> toReserve = new List<Material>();

        ApplicationLayer.Reservations res;
        public ReservationConfirmation(Visitor leader, List<Visitor> members, List<MapLocation> maplocations, List<Material> toReserve)
        {
            InitializeComponent();
            this.leader = leader;
            this.members = members;
            this.maplocations = maplocations;
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
            string leaderId = leader.RFID;
            res.AddVisitorLeader(leader);
            if(members != null)
            {
                foreach (Visitor V in members)
                {
                    res.AddVisitor(V, leaderId);
                }
            }
            if (maplocations != null)
            {
                foreach (MapLocation M in maplocations)
                {
                    res.RentWithXandYPosition(M.Coordinates.X, M.Coordinates.Y, leaderId);
                }
            }

            if (toReserve != null)
            {
                foreach (Material M in toReserve)
                {
                    res.RentWithMaterialId(M.MaterialId);
                }
            }
            this.Close();
                //sent alles close alls
        }

        private void btnReservationConfirmationPrevious_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
