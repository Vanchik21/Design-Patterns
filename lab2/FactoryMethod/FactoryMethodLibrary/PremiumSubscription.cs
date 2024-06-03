using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodLibrary
{
    public class PremiumSubscription : Subscription
    {
        public override void GetDetails()
        {
            Console.WriteLine("Premium Subscription: $25/month, Min. period: 6 months, Channels: All");
        }
    }
}
