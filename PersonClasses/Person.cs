using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClasses
{
    public class Person: BaseClass // klass Person on tuletatud klassis object
    {
        private DateTimePeriod dateOfBirth;
        public string Name { get; set; }
        public string NationalID { get; set; }
        public Gender Gender { get; set; }

        public GeographicAddresses Address
        {
            get; set;
        }

        public DateTimePeriod DateOfBirth
        {
            get { return dateOfBirth; }
            set { SetValue(ref dateOfBirth, value); }
        }

    }
}
