using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using System.Text.RegularExpressions;

namespace MedicalClinic
{
    public class InvalidPropertyException : Exception
    {
        public InvalidPropertyException(string meessage) : base(meessage)
        {
        }
    }
    class PatientDataValidate
    {
        public enum State { AllowEmpty, NotAllowEmpty};
        private State state;

        public PatientDataValidate(State state)
        {
            this.state = state;
        }

        public void validate(patient toCheck)
        {
            Regex onlyCharacters = new Regex(@"^\p{L}+$");
            Regex onlyNumbers = new Regex(@"\p{Nd}+$");
            
            if ( !onlyCharacters.IsMatch(toCheck.first_name) && !this.propertyIsEmpty(toCheck.first_name) )
            {
                throw new InvalidPropertyException("Pole imię powinno posiadać tylko litery.");
            }

            if (!onlyCharacters.IsMatch(toCheck.last_name) && !this.propertyIsEmpty(toCheck.last_name) )
            {
                throw new InvalidPropertyException("Pole nazwisko powinno zawierać tylko litery");
            }

            if (!onlyNumbers.IsMatch(toCheck.PESEL) && !this.propertyIsEmpty(toCheck.PESEL))
            {
                throw new InvalidPropertyException("Pole PESEL powinno zawierać tylko cyfry");
            }

            if (toCheck.PESEL.Length != 11 && !this.propertyIsEmpty(toCheck.PESEL))
            {
                throw new InvalidPropertyException("Numer PESEL powinna posiadać jedenaście(11) cyfr.");
            }
        }

        private bool propertyIsEmpty(string property)
        {
            bool allowEmpty = this.state == State.AllowEmpty;
            return allowEmpty ? property.Length == 0 : false;
        }
    }
}
