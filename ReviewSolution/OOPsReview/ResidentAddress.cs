using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsReview.Data
{
    public struct ResidentAddress
    {
        //data members
        public int Number;
        public string Address1;
        public string Address2;
        private string _Unit;
        private string _City;
        public string ProvinceState;

        public string Unit
        {
            get { return _Unit; }
            set { _Unit = value; }
        }

        public string City
        {
            get { return _City; }
            set { _City = value; }
        }

        public ResidentAddress(int Number, string Address1, string Address2,
                                string Unit, string City, string ProvinceState)
        {
            this.Number = Number;
            this.Address1 = Address1;
            this.Address2 = Address2;
            _Unit = Unit;
            _City = City;
            this.ProvinceState = ProvinceState;
        }

        public override string ToString()
        {
            return $"{Number},{Address1},{Address2},{Unit},{City},{ProvinceState}";
        }
    }
}
