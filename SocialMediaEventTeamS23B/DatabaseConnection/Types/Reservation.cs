using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnection.Types
{
    class Reservation
    {
        public List<Visitor> GroupMembers { get; private set; }
        public Visitor GroupLeader { get; private set; }
        public List<MapLocation> Locations { get; private set; }

        public Reservation(List<Visitor> groupMembers, Visitor groupLeaader, List<MapLocation> locations)
        {
            GroupMembers = groupMembers;
            GroupLeader = groupLeaader;
            Locations = locations;
        }

        public override string ToString()
        {
            var members = string.Join(",", GroupMembers.Select(member => member.ToString()));
            var locations = string.Join(",", Locations.Select(loc => loc.ToString()));
            return string.Format("{{GroupMembers=[{0}],GroupLeader={1},Locations=[{2}]",members,GroupLeader,locations);
        }
    }
}
