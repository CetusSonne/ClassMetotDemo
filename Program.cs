using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sadece "listeleme" eklenmiştir.

            Customer customer1 = new Customer();
            Customer customer2 = new Customer();
            CustomerManager customerManager = new CustomerManager();


            customerManager.Welcome();
           
            //----------------------------------Müşteri Bilgileri----------------------------------\\
            customer1.Id = 111111;
            customer1.Age = 15;
            customer1.Name = "Bora";
            customer1.LastName = "Kıroğlu";
            customer1.Sex = "Male";

            customer2.Id = 111112;
            customer2.Age = 19;
            customer2.Name = "Uğur";
            customer2.LastName = "Kıroğlu";
            customer2.Sex = "Male";
            //-------------------------------------------------------------------------------------\\
            Customer[] customers = new Customer[] {customer1 , customer2};

            foreach (var x in customers)
            {
                Console.WriteLine("--------------------");
                customerManager.Listeleme(x);
                Console.WriteLine("--------------------");
            }
        }
    }
}
