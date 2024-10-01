using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models.Type
{
    public enum SubscriptionState
    {
        Enabled,
        Warned,
        PastDue,
        Disabled,
        Deleted,
        Unknow,
    }
}
