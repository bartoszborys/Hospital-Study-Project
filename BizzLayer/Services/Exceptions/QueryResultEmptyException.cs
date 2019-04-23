using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizzLayer.Services.Registration.Exceptions
{
    public class QueryResultEmptyException : Exception
    {
        public QueryResultEmptyException(string message = "") : base("Query returned an empty result." + ( message.Length>0 ? "Details: " + message : "" ) ) { }
    }
}
