using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodLibrary
{
    public class DomesticSubscription : Subscription
    {
        public override void GetDetails()
        {
            Console.WriteLine("Domestic Subscription: $10/month, Min. period: 1 month, Channels: Basic");
        }
    }
}