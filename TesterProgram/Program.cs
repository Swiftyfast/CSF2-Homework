using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesLibrary;

namespace TesterProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //*******
            Student mumford = new Student("Marcus", "Mumford", "1900", 3.2f);

            Student ferdinand = new Student();
            ferdinand.LastName = "Ferdinand";
            ferdinand.FirstName = "Franz";
            ferdinand.Gpa = 3.9f;
            ferdinand.Id = "17";

            Console.WriteLine(ferdinand);
            Console.WriteLine(mumford);

            //******
            Vehicle falcon = new Vehicle("Corellian Corvette", "YT-1300", 5, 30000);

            Vehicle enterprise = new Vehicle();
            enterprise.Make = "Federation Starship";
            enterprise.Model = "Galaxy Class";
            enterprise.Year = 2300;
            enterprise.Weight = 1000000;

            Console.WriteLine(enterprise);
            Console.WriteLine(falcon);

            //*******

            Login myActualLogin = new Login("myName", "12345");

            Login secondLogin = new Login();
            secondLogin.Username = "madeUpName";
            secondLogin.Password = "020202";

            Console.WriteLine(myActualLogin);
            Console.WriteLine(secondLogin);

            //********

            ContactInfo myInfo = new ContactInfo("3180 Main Street", "Kansas City", "KS", "45825", "913-555-5885", "email@email.com");

            ContactInfo newAddress = new ContactInfo();
            newAddress.StreetAddress = "100 S. Baker Street";
            newAddress.City = "London";
            newAddress.State = "MO";
            newAddress.Zip = "10000";
            newAddress.Phone = "816-555-4000";
            newAddress.Email = "notADoctor@email.com";

            //Console.WriteLine(myInfo);
            //Console.WriteLine(newAddress);

            //********

            Customer doorBuster = new Customer("789", "Upton", "Sinclar", myInfo);

            Customer carlSagan = new Customer();
            carlSagan.CustomerId = "790";
            carlSagan.FirstName = "Carl";
            carlSagan.LastName = "Sagan";
            carlSagan.ContactInformation = newAddress;

            Console.WriteLine("\n");
            Console.WriteLine(doorBuster);
            Console.WriteLine("\n");
            Console.WriteLine(carlSagan);

            //*************

            CreditCardAccount account1 = new CreditCardAccount(1700, doorBuster, 7256.3m, false, .1m);

            CreditCardAccount account2 = new CreditCardAccount();
            account2.AccountNumber = 1701;
            account2.AnnualInterestRate = .05m;
            account2.Balance = 304.12m;
            account2.CustomerInfo = carlSagan;
            account2.IsPastDue = false;

            Console.WriteLine("\n");
            Console.WriteLine(account1);
            Console.WriteLine("\n");
            Console.WriteLine(account2);

        }
    }
}
