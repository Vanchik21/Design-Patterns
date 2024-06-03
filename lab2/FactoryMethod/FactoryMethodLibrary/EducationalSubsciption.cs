using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodLibrary
{
    public class EducationalSubscription : Subscription
    {
        public override void GetDetails()
        {
            Console.WriteLine("Educational Subscription: $15/month, Min. period: 3 months, Channels: Educational");
        }
    }
}
