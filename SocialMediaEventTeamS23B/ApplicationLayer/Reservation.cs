using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseConnection.Types;

namespace ApplicationLayer
{
    public class Reservation
    {
        public List<Visitor> GroupMembers { get; private set; }

        public Reservation(List<Visitor> groupMember, Visitor groupLeader, List<MapLocation> Location)
        {
            groupMember = null;
            Location = null;

        }

    }
}
