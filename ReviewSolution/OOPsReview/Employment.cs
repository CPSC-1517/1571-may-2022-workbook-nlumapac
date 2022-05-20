using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsReview.Data
{
    public class Employment
    {
        //An instance of this class will hold data about a person's employment
        //The code of this class is the definition of that data
        //The characteristics (data) of the class
        //Title, SupervisoryLevel, Years of employment within the company

        //There are 4 components of a class definition
        //  data fields (data members)
        //  property
        //  constructor
        //  behaviour (method)

        //data fields
        //  are storage areas in your class
        //  these are treated as variables
        //  these may be public, private, public readonly
        private string _Title;
        private double _Years;

        //property
        //  These are access techniques to retrieve or set data in
        //  your class without directly touching the storage data field

        //A property is associated with a single instance of data
        //A property is public so it can be access by an outside user of the class
        //A property MUST have a get
        //A property MUST have a set
        //  if no set, the property is not changeable by the user; readonly
        //  commonly use for calculated data of the class
        //  the set can be either public or private
        //  public: the user can alter the contents of the data
        //  private: only code within the class can alter the contents

        //fully implented property
        // a) a declared storage area (data field)
        // b) a declared property signature (access rdt propertyname)
        // c) a coded accessor (get) : public
        // d) an optional coded mutator (set) : public or private
        //  if the set is private and only 


        public string Title
        {
            get 
            {
                //accessor
                //teh get "method" will return teh contents of a data field(s)
                //the return has syntax of return expression
                return _Title;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new AggregateException("Title is a required piece of data.");
                }

                //data is consider valid
                _Title = value;
            }
        }

        public SupervisoryLevel Level { get; set; }

        public double Years
        {
            get { return _Years; }
            set
            {
                if (!Utilities.IsZeroPositive(value))
                {
                    throw new ArgumentOutOfRangeException($"Years of {value} is invalid.");
                }
                _Years = value;
            }
        }

        public Employment()
        {
            Level = SupervisoryLevel.TeamMember;
            Title = "Unknown";
        }

        //Greedy Constructor
        public Employment(string title, SupervisoryLevel level, double years = 0.0)
        {
            Title=title;
            Years=years;
            Level = level;
        }

        public override string ToString()
        {
            return $"{Title}, {Level}, {Years}"; 
        }

        public void SetEmploymentResponsibilityLevel(SupervisoryLevel level)
        {
            Level = level;
        }
    }
}
