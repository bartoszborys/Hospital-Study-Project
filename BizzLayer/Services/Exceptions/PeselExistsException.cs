using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizzLayer.Services.Registration.Exceptions
{
    public class PeselExistsException : Exception
    {
        public string pesel;
        public PeselExistsException(string pesel) : base("Pesel exists") { this.pesel = pesel; }
    }
}
