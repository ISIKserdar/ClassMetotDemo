using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustemerManager
    {
        public void add(Customer customer)
        {
            Console.WriteLine(customer.Name + customer.Surname + "DataBase'e eklendi.");
        
        }


        public void list(Customer customer)
        {

            Console.WriteLine(customer.Id + "  Id numaralı müşteri listelendi.");
        }

        public void update (Customer customer)
        {

            Console.WriteLine("veritabanımıza 1 yeni müşteri eklendi.");
        }

       public void info (Customer customer)
        {
            Console.WriteLine(customer.Id +"\n"+ customer.Name +"\n"+ customer.Surname+"\n"+customer.TCId+"\n"+customer.City+"\n");
        }

    }
}
