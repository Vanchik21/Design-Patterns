using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodLibrary
{
    public interface ISubscriptionFactory
    {
        Subscription CreateSubscription(string type);
    }
}
