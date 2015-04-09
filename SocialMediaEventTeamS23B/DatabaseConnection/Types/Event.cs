using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseConnection.Exeptions;

namespace DatabaseConnection.Types
{
    public class Event
    {
        public int EventId { get; private set; }
        public Location Location { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }

        public Event(int eventId, Location location, DateTime startDate, DateTime endDate)
        {
            if (endDate < startDate)
            {
                throw new InvalidDateException("endDate is before startDate");
            }
            EventId = eventId;
            Location = location;
            StartDate = startDate;
            EndDate = endDate;
        }

        public override string ToString()
        {
            return String.Format("{{EventId={0},Location={1},StartDate={2},EndDate={3}}}",EventId,Location,StartDate,EndDate);
        }
    }
}
