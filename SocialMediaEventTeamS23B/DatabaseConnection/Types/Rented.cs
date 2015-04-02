using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseConnection.Exeptions;

namespace DatabaseConnection.Types
{
    class Rented
    {
        public List<Material> Materials { get; private set; }
        public DateTime BeginHire { get; private set; }
        public DateTime EndHire { get; private set; }

        public Rented(List<Material> materials, DateTime beginHire, DateTime endHire)
        {
            if (endHire < beginHire)
            {
                throw new InvalidDataException("endHire < beginHire");
            }
            Materials = materials;
            BeginHire = beginHire;
            EndHire = endHire;
        }

        public override string ToString()
        {
            var materials = String.Join(",", Materials.Select(mat => mat.ToString()));
            return String.Format("{{Materials=[{0}],BeginHire={1},EndHire={2}}}", materials, BeginHire, EndHire);
        }
    }
}
