using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Exceptions
{
    class NullException:Exception
    {
        public NullException(String message): base(message)
        {

        }
    }
}
