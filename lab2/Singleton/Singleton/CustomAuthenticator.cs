using Singleton;
using System;

namespace Singleton
{
    public class CustomAuthenticator : Authenticator
    {
        private CustomAuthenticator() 
        { 
            Console.WriteLine("CustomAuthenticator initialized.");
        }
    }
}