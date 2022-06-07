using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsReview.Data
{
    public class Person
    {
        private string _FirstName;
        private string _LastName;

        public string FirstName
        {
            get { return _FirstName; }
            private set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("First name is required");
                }

                _FirstName = value; 
            }
        }

        public string LastName
        {
            get { return _LastName; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Last name is required");
                }

                _LastName = value;
            }
        }

        public ResidentAddress Address;

        public List<Employment> EmploymentPositions { get; private set; }

        public Person()
        {
            FirstName = "Unknown";
            LastName = "Unknown";
            EmploymentPositions = new List<Employment>();
        }
    }
}
