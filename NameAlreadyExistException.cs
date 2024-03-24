using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreV2
{
    public class NameAlreadyExistException:Exception
    {
        public NameAlreadyExistException() 
        { 
        }

        public NameAlreadyExistException(string message) : base(message) 
        { 
        }
    }
}
