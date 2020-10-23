using System;
using System.Collections.Generic;
using System.Text;

namespace MockPracticalExam2
{
    class Alien
    {
        private string name;

        public string Name
        {
            get { return name; }
            set {
                if (value == "")
                    name = "Unidentified";
                else
                    name = value;
            }
        }

        private DateTime date;

        public DateTime Date
        {
            get { return date; }
            set {
                if (value.ToLongDateString() == "")
                    date = DateTime.Now;
                else
                    date = value;
            }
        }

        private string location;
        public string Location
        {
            get { return location;  }
            set
            {
                if(value == "")
                {
                    location = "N/A";
                }
                else
                {
                    location = value;
                }
                    
            }
        }

        public Alien()
        {
            Name = "Unidentified";
            Date = DateTime.Now;

        }

        public Alien(string _name, DateTime _date, string _location)
        {
            Name = _name;
            Date = _date;
            Location = _location;
        }
    }
}
