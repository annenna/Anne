using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Gaming.Input.ForceFeedback;

namespace PersonClasses
{
    public class DateTimePeriod: Period<DateTime>
    {
        private DateTime f;
        private DateTime t;

        public DateTime From { get; set; }
        public DateTime To { get; set; }
    }
}
