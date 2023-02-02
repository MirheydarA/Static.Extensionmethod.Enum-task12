using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Static.Extensionmethod.Enum
{
    internal  class User
    {
        private string name;
        private string surname;
        private string pin;
        
        public string Name { get; set; }
        public string Surname { get; set; }
        public Month RegistrationMonth { get; set; }

        public string PIN { get {return PIN; } set { PIN = value;} }

        public User(string name,string surname, string PIN, Month month)
        {
            this.name = name;
            this.surname = surname;
            RegistrationMonth = month;
            this.PIN = pin; 
        }

        public string GetDetails()
        {
            return $"{Name} {Surname} {PIN} {RegistrationMonth}";
            
                            
        }

        public static bool CheckPIN(string PIN)
        {
            if (PIN.Length == 7 )
            {
                return true;
            }
            throw new Exception();
        }
    }
    enum Month
    {
        January = 1,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        Septemper,
        October,
        November,
        December
    }
}
