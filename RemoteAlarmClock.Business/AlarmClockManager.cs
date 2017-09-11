using RemoteAlarmClock.BusinessShared;
using RemoteAlarmClock.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteAlarmClock.Business
{
    public class AlarmClockManager : IAlarmClockManager
    {
        private List<AlarmClock> _alarms;

        public AlarmClockManager()
        {
            _alarms = new List<AlarmClock>();
        }

        public bool IsAlarmRinging()
        {
            return _alarms.Any((alarm) => alarm.Alarm < DateTime.Now);
        }

        public void SetAlarmClock(AlarmClock newAlarm)
        {
            _alarms.Add(newAlarm);
        }
    }
}
