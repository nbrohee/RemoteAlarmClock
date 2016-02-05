using Microsoft.VisualStudio.TestTools.UnitTesting;
using RemoteAlarmClock.Business;
using RemoteAlarmClock.Common;
using RemoteAlarmClock.Web.Controllers;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace RemoteAlarmClock.Web.Tests
{
    [Binding]
    public class AlarmClockSteps
    {
        private AlarmClockManager _alarmManager = null;
        private AlarmClockController _alarmController = null;
        private AlarmClock _alarmToRegister = null;

        public AlarmClockSteps()
        {
            _alarmManager = new AlarmClockManager();
            _alarmController = new AlarmClockController(_alarmManager);
        }

        [Given(@"I have a new alarm to register")]
        public void GivenIHaveANewAlarmToRegister()
        {
            _alarmToRegister = new AlarmClock(DateTime.Now.AddSeconds(2));
        }
        
        [When(@"I submit my new alarm")]
        public void WhenISubmitMyNewAlarm()
        {
            _alarmController.Post(_alarmToRegister);
        }
        
        [Then(@"the computer must ring at the alarm set time")]
        public void ThenTheComputerMustRingAtTheAlarmSetTime()
        {
            Thread.Sleep(2000);
            Assert.IsTrue(_alarmManager.IsAlarmRinging);
        }
    }
}
