using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseConnection.Exceptions;

namespace DatabaseConnection.Types
{
    public class MapLocation
    {
        public int LocationNumber { get; private set; }
        public Point Coordinates { get; private set; }
        public Point Seize { get; private set; }
        public String Cat { get; private set; }

        public MapLocation(int locationNumber, Point coordinates, Point seize, string cat)
        {
            if (locationNumber <= 0)
            {
                throw new InvalidDataException("Invallid location number");
            }
            LocationNumber = locationNumber;
            Coordinates = coordinates;
            Seize = seize;
            Cat = cat;
        }

        public override string ToString()
        {
            return String.Format("{{LocationNumber={0},MapX={1},MapY={2},SizeX={3},SizeY={4},Category={5}}}",LocationNumber,Coordinates.X,Coordinates.Y, Seize.X, Seize.Y, Cat);
        }
    }
}
