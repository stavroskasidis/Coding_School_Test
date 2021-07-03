using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingSample
{
    public enum TimeOfDay
    {
        Night,
        Morning,
        Noon,
        Evening
    }

    public class TimeOfDayProvider
    {
        public TimeOfDay GetTimeOfDay()
        {
            var dateTime = DateTime.Now;
            if (dateTime.Hour >= 0 && dateTime.Hour < 6)
            {
                return TimeOfDay.Night;
            }
            if (dateTime.Hour >= 6 && dateTime.Hour < 12)
            {
                return TimeOfDay.Morning;
            }
            if (dateTime.Hour >= 12 && dateTime.Hour < 18)
            {
                return TimeOfDay.Noon;
            }
            return TimeOfDay.Evening;
        }
    }
}
