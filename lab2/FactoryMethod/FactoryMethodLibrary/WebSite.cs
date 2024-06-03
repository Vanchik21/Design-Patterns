using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodLibrary
{
    public class WebSite : ISubscriptionFactory
    {
        public Subscription CreateSubscription(string type)
        {
            switch (type)
            {
                case "Domestic":
                    return new DomesticSubscription();
                case "Educational":
                    return new EducationalSubscription();
                case "Premium":
                    return new PremiumSubscription();
                default:
                    throw new ArgumentException("Invalid subscription type");
            }
        }
    }
}
