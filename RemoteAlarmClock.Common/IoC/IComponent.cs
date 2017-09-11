using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteAlarmClock.Common.IoC
{
    public interface IComponent
    {
        void SetUp(IRegisterComponent registerComponent);
    }
}
