using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseConnection.Exceptions;

namespace DatabaseConnection.Types
{
   public class Material
    {
        public int MaterialId { get; private set; }
        public String Name { get; private set; }
        public String Type { get; private set; }
        public Double Price { get; private set; }
        public Double Rent { get; private set; }
        public String State { get; private set; }

        public Material(int materialId, string name, string type, double price, double rent, String state)
        {
            if (materialId < 0)
            {
                throw new InvalidDataException("MaterialId < 0");
            }
            if (string.IsNullOrEmpty(name))
            {
                throw new InvalidDataException("Name is empty");
            }
            if (price <= 0)
            {
                throw new InvalidDataException("price <= 0");
            }
            if (rent <= 0)
            {
                throw new InvalidDataException("Rent <= 0");
            }
            if (string.IsNullOrEmpty(type))
            {
                throw new InvalidDataException("Type is empty");
            }
            if (string.IsNullOrEmpty(state))
            {
                throw  new InvalidDataException("State is empty");
            }
            MaterialId = materialId;
            Name = name;
            Type = type;
            Price = price;
            Rent = rent;
            State = state;
        }

        public override string ToString()
        {
            return String.Format("{{MaterialId={0},Name={1},Price={2},Rent={3},State{4}}}",MaterialId,Name,Price,Rent,State);
        }
    }
}
