using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {   //Gerçek Müşteri - Tüzel Müşteri
            
            //Yavuz Selim Kahyaoğlu
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 0;
            customer1.CustomerNo = "544";
            customer1.Name = "Yavuz Selim";
            customer1.Surname = "Kahyaoğlu";
            customer1.TcNo ="22222222222";

            //Kodlama.io
            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 1;
            customer2.CustomerNo = "404";
            customer2.CompanyName="Kodlama.io";
            customer2.TaxNo = "27";
            //SOLID

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);
        }
    }
}
