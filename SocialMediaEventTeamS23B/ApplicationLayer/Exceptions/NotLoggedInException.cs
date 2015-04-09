using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Exceptions
{
    class NotLoggedInException:Exception
    {
        public NotLoggedInException(String message):base(message)
        {
            
        }
    }
}
