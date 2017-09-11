using RemoteAlarmClock.BusinessShared;
using RemoteAlarmClock.Common.IoC;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteAlarmClock.Business
{
    [Export(typeof(IComponent))]
    public class DependencyResolver : IComponent
    {
        public void SetUp(IRegisterComponent registerComponent)
        {
            registerComponent.RegisterType<IAlarmClockManager, AlarmClockManager>();

        }
    }
}
