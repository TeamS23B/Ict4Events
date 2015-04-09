using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseConnection.Exeptions;

namespace DatabaseConnection.Types
{
    public class Reservation
    {
        public List<Visitor> GroupMembers { get; private set; }
        public Visitor GroupLeader { get; private set; }
        public List<MapLocation> Locations { get; private set; }

        public Reservation(List<Visitor> groupMembers, Visitor groupLeader, List<MapLocation> locations)
        {
            if (groupMembers == null || groupLeader == null || locations == null)
            {
                throw new InvalidDataException("Groupmembers, Groupleader or locations is empty");
            }
            GroupMembers = groupMembers;
            GroupLeader = groupLeader;
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
