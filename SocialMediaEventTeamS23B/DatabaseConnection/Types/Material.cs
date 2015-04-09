using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseConnection.Exeptions;

namespace DatabaseConnection.Types
{
   public class Material
    {
        public int MaterialId { get; private set; }
        public String Name { get; private set; }
        public Double Price { get; private set; }
        public String State { get; private set; }

        public Material(int materialId, string name, double price, String state)
        {
            if (materialId < 0)
            {
                throw new InvalidDataException("MaterialId < 0");
            }
            if (string.IsNullOrEmpty(name))
            {
                throw new InvalidDataException("Name is empty");
            }
            if (price < 0)
            {
                throw new InvalidDataException("price < 0");
            }
            if (string.IsNullOrEmpty(state))
            {
                throw  new InvalidDataException("State is empty");
            }
            MaterialId = materialId;
            Name = name;
            Price = price;
            State = state;
        }

        public override string ToString()
        {
            return String.Format("{{MaterialId={0},Name={1},Price={2},State{3}}}",MaterialId,Name,Price,State);
        }
    }
}
