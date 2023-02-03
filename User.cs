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
        private string pin;
        
        public string Name { get; set; }
        public string Surname { get; set; }
        public Month RegistrationMonth { get; set; }
        public string PIN
        {
            get 
            { 
                return pin; 
            }
            set
            {
                if (value.CheckPIN())
                {
                    pin = value;
                }
                else
                {
                    throw new Exception("something wrong");
                }
            } 
        }

       
        public User(string name,string surname, string pin, Month month)
        {
            Name = name;
            Surname = surname;
            RegistrationMonth = month;
            PIN = pin; 
        }

       
        public string GetDetails()
        {
            return $"{Name} {Surname} {PIN} {(int)RegistrationMonth}";
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
