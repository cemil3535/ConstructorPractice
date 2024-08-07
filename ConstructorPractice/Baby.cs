using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorPractice
{
    internal class Baby
    {
        private string _name;
        private string _surname;
        private DateTime _dateTime;

        // Default Constructor to identify
        public Baby()
        {
            Console.WriteLine($"Ingaaaa {DateTime.Now}");
        }


        // Alternative to identify
        public Baby(string name, string surname)
        {
            _name = name;
            _surname = surname;
            Console.WriteLine($"{_name} {_surname} Ingaaa {DateTime.Now}");
            
        }


        // Properties Created
        public string Name
        {
            get
            {
                return _name;

            }
            set
            {
                _name = value;
            }
        }

        public string Surname
        {
            get
            {
                return _surname;

            }
            set
            {
                _surname = value;
            }

        }

        public DateTime DateTime
        {
            get
            {
                return _dateTime;
            }
            set
            {
                _dateTime = value;
            }
        }
    }
}

