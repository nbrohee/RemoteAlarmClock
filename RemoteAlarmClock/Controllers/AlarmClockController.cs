using RemoteAlarmClock.Business;
using RemoteAlarmClock.BusinessShared;
using RemoteAlarmClock.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RemoteAlarmClock.Web.Controllers
{
    public class AlarmClockController : ApiController
    {
        private IAlarmClockManager _alarmManager;

        public AlarmClockController(IAlarmClockManager alarmMananager)
        {
            _alarmManager = alarmMananager;
        }

        // POST: api/Clock
        public HttpResponseMessage Post([FromBody]AlarmClock newAlarmClock)
        {
            _alarmManager.SetAlarmClock(newAlarmClock);
            return new HttpResponseMessage(HttpStatusCode.NoContent);
        }
    }
}
