using FactoryMethodLibrary;
using System;

namespace FactoryMethodApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ISubscriptionFactory websiteFactory = new WebSite();
            ISubscriptionFactory mobileAppFactory = new MobileApp();
            ISubscriptionFactory managerCallFactory = new ManagerCall();

            Subscription domesticSubscription = websiteFactory.CreateSubscription("Domestic");
            Subscription educationalSubscription = mobileAppFactory.CreateSubscription("Educational");
            Subscription premiumSubscription = managerCallFactory.CreateSubscription("Premium");

            domesticSubscription.GetDetails();
            educationalSubscription.GetDetails();
            premiumSubscription.GetDetails();
        }
    }
}