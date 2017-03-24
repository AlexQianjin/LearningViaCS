using System;

namespace Proxy
{
    class Program:SubjectAccessor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Proxy Pattern\n");

            ISubject subject = new Proxy();
            Console.WriteLine(subject.Request());
            Console.WriteLine(subject.Request());

            ISubject protectionSubject = new ProtectionProxy();
            Console.WriteLine(protectionSubject.Request());
            Console.WriteLine((protectionSubject as ProtectionProxy).Authenticate("Secret"));
            Console.WriteLine((protectionSubject as ProtectionProxy).Authenticate("Abracadabra"));
            Console.WriteLine(protectionSubject.Request());

            Console.ReadLine();
        }
    }
}