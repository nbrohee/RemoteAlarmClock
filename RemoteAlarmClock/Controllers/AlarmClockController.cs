using RemoteAlarmClock.BusinessShared;
using RemoteAlarmClock.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace RemoteAlarmClock.Web.Controllers
{
    public class AlarmClockController : ApiController
    {
        private IAlarmClockManager _alarmManager;

        public AlarmClockController(IAlarmClockManager alarmMananager)
        {
            _alarmManager = alarmMananager;
        }

        [ResponseType(typeof(AlarmClock))]
        public HttpResponseMessage Get(int id)
        {
            return this.Request.CreateResponse<AlarmClock>(null);
        }

        // POST: api/Clock
        public HttpResponseMessage Post([FromBody]AlarmClock newAlarmClock)
        {
            _alarmManager.SetAlarmClock(newAlarmClock);
            return new HttpResponseMessage(HttpStatusCode.NoContent);
        }
    }
}
