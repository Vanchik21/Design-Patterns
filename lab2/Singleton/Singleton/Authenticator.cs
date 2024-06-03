using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Authenticator
    {
        private static readonly Lazy<Authenticator> instance =
            new Lazy<Authenticator>(() => new Authenticator());

        protected Authenticator()
        {
            if (instanceCreated)
            {
                throw new InvalidOperationException("Instance already created.");
            }
            instanceCreated = true;
            Console.WriteLine("Authenticator initialized.");
        }

        private static bool instanceCreated = false;

        public static Authenticator Instance
        {
            get
            {
                return instance.Value;
            }
        }

        public void Authenticate()
        {
            Console.WriteLine("Authentication successful.");
        }
    }
}
