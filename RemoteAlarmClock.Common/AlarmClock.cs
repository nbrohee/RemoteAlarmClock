using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteAlarmClock.Common
{
    public class AlarmClock
    {
        public DateTime Alarm { get; }

        public AlarmClock(DateTime alarm)
        {
            Alarm = alarm;
        }
    }
}
