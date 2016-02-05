using RemoteAlarmClock.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteAlarmClock.BusinessShared
{
    public interface IAlarmClockManager
    {
        /// <summary>
        /// Set a new alarm clock
        /// </summary>
        /// <param name="newAlarm"></param>
        void SetAlarmClock(AlarmClock newAlarm);
    }
}
