using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    public class SubjectAccessor
    {
        public interface ISubject
        {
            string Request();
        }

        private class Subject
        {
            public string Request()
            {
                return "Subject Request " + "Choose left door\n";
            }
        }

        public class Proxy : ISubject
        {
            private Subject subject;

            public string Request()
            {
                if (subject == null)
                {
                    Console.WriteLine("Subject inactive");
                    subject = new Subject();
                }
                Console.WriteLine("Subject active");
                return "Proxy: Call to " + subject.Request();
            }
        }

        public class ProtectionProxy : ISubject
        {
            private Subject subject;
            private string password = "Abracadabra";

            public string Authenticate(string supplied)
            {
                if (supplied != password) 
                {
                    return "Protection Proxy: No access";
                }
                else
                {
                    subject = new Subject();
                    return "Protection Proxy: Authenticated";
                }
            }

            public string Request()
            {
                if (subject == null)
                {
                    return "Protection Proxy: Authenticate first";
                }
                else
                {
                    return "Protection Proxy: Call to " + subject.Request();
                }
            }
        }
    }
}
