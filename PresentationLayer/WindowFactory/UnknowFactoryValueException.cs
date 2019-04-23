using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalClinic.windowFactory
{
    class UnknowFactoryValueException : Exception
    {
        public UnknowFactoryValueException(string message) : base(message)
        {
        }
    }
}
