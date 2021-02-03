using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 801;
            customer1.Name = "serdar";
            customer1.Surname = "ISIK";
            customer1.TCId = "20455626730";
            customer1.City = "BURSA";


            CustemerManager custemerManager = new CustemerManager();
            custemerManager.add(customer1);
            custemerManager.list(customer1);
            custemerManager.update(customer1);

            Console.WriteLine();

            custemerManager.info(customer1);

        }
    }
}
