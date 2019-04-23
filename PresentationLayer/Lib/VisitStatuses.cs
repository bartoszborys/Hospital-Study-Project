using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalClinic
{
    public static class VisitStatuses
    {
        public enum Statuses { Start, Execution, Rejected, Finished };

        public static string get(Statuses value)
        {
            switch (value)
            {
                case Statuses.Start:
                    return "S";

                case Statuses.Execution:
                    return "E";

                case Statuses.Rejected:
                    return "R";

                case Statuses.Finished:
                    return "F";

                default:
                    throw new Exception();
            }
        }
    }
}
