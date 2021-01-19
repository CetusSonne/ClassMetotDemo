using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        
        public void Welcome()
        {
            Console.WriteLine("Welcome to SonneBank Customer System!");
        }
        
        public void Listeleme(Customer x)
        {
            Console.WriteLine(x.Age);
            Console.WriteLine(x.Name);
            Console.WriteLine(x.LastName);
            Console.WriteLine(x.Sex);
        }
    }
}
