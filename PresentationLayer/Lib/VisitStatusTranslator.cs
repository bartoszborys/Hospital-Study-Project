using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalClinic
{
    public class VisitStatusTranslator
    {
        public VisitStatusTranslator()
        {

        }

        public string translate(string sign)
        {
            switch(sign)
            {
                case "S":
                    return "Rozpoczęta";

                case "E":
                    return "Wykonywana";

                case "R":
                    return "Anulowana";

                case "F":
                    return "Zakończona";

                default:
                    throw new Exception();
            }
        }

        public string untranslate(string word)
        {
            switch (word)
            {
                case "Rozpoczęta":
                    return "S";

                case "Wykonywana":
                    return "E";

                case "Anulowana":
                    return "R";

                case "Zakończona":
                    return "F";

                default:
                    throw new Exception();
            }
        }
    }
}
