using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseConnection.Exeptions;

namespace DatabaseConnection.Types
{
    public class MapLocation
    {
        public int LocationNumber { get; private set; }
        public Point Coordinates { get; private set; }

        public MapLocation(int locationNumber, Point coordinates)
        {
            if (locationNumber <= 0)
            {
                throw new InvalidDataException("Invallid location number");
            }
            LocationNumber = locationNumber;
            Coordinates = coordinates;
        }

        public override string ToString()
        {
            return String.Format("{{LocationNumber={0},MapX={1},MapY={2}}}",LocationNumber,Coordinates.X,Coordinates.Y);
        }
    }
}
