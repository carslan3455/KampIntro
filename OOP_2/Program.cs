using System;

namespace OOP_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sinem Acar- Inheritance uygulamadan onceki tanimlama
            //Customer customer1 = new Customer();
            //customer1.FirstName = "Sinem";
            //customer1.LastName = "Acar";
            //customer1.Id = 1;
            //customer1.TcNo = "2222222";
            //customer1.CustomerNumber = "12345";
            //customer1.CompanyName = "?";
            // customer1.CustomerType = 1;   bu sekilde bu formatu kurtarmaya calissak ta aslinda yanlis bir tanimlama

            // Gercek Musteri - Tüzel Musteri  : ikiside Customer turu ama birbirlerinin yerine asla kullanilamaz


            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNumber = "12345";
            customer1.FirstName = "Sinem";
            customer1.LastName = "Acar";
            customer1.TcNo = "12345678910";


            // Techno Study

            CoorporateCustomer customer2 = new CoorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNumber = "54321";
            customer2.CompanyName = "Techno Study";
            customer2.VergiNo = "1234567890";

            // Gercek Musteri - Tüzel Musteri  / SOLID kurali


            // Customer        =  Ref.No  Hem Gercek, hem de Tüzel Musterinin referansini adresini tutabiliyor  
            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CoorporateCustomer();


            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);   // Gercek Musteri de ayni methoda gidebiliyor
            customerManager.Add(customer2);   // Tüzel Musteri de ayni methoda gidebiliyor.
            //  Bunu saglayan Inheritance




        }
    }
}
