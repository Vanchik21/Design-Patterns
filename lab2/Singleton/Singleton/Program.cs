using System;
using System.Threading.Tasks;
using Singleton;

namespace DeviceFactoryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
                () => AccessAuthenticator(),
                () => AccessAuthenticator()
            );
        }

        private static void AccessAuthenticator()
        {
            Authenticator auth = Authenticator.Instance;
            auth.Authenticate();
            Console.WriteLine(auth.GetHashCode());
        }
    }
}