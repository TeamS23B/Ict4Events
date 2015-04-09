using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationLayer.Exceptions;
using DatabaseConnection.Types;

namespace ApplicationLayer
{
    public class Reservation
    {
        public List<Visitor> GroupMembers { get; private set; }

        public Reservation(List<Visitor> groupMember, Visitor groupLeader, List<MapLocation> Location)
        {
            if (groupMember == null || Location == null)
            {
                throw new NullException("Lists don't exist");
            }
        }

    }
}
