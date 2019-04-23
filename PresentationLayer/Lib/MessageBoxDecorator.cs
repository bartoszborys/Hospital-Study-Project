using System;using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalClinic
{
    class MessageBoxDecorator
    {
        public static void ErrorBoxLogin(string message)
        {
            MessageBox.Show(message, "Błąd podczas logowania!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ErrorBox(string message)
        {
            MessageBox.Show(message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void InfoBox(string message)
        {
            MessageBox.Show(message, "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void SuccessBox(string message)
        {
            MessageBox.Show(message, "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        public static void ActionSuccess()
        {
            MessageBoxDecorator.SuccessBox("Akcja zakończona pomyślnie");
        }
    }
}
