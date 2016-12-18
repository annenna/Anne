using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClasses
{
    public class GeographicAddress : BaseClass
    {
        private DateTimePeriod valid;
        private string adressLine;
        private string town;

        public string AddressLine
        {
            get { return AddressLine; }
            set { SetValue(ref adressLine, value);}
        }

        public string Town
        {
            get { return Town; }
            set { SetValue(ref town, value);}
        }

        public DateTimePeriod Valid
        {
            get { return valid; }
            set { SetValue(ref valid, value);}
        } 
    }
}
