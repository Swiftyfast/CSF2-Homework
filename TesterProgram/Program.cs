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

            //***********

            Book frankenstein = new Book("Frankenstein", "Mary Shelly", 300);

            Book foreverWar = new Book("The Forever War", "Joe Haldman", 320);

            Book fourteenNinetyOne = new Book("1491", "Charles C. Mann", 400);

            Book lotr = new Book();
            lotr.Title = "Lord of the Rings";
            lotr.Author = "J.R.R. Tolkein";
            lotr.NumberOfPages = 1200;

            Console.WriteLine("\n");
            Console.WriteLine(frankenstein);
            Console.WriteLine("\n");
            Console.WriteLine(lotr);

            //*************

            List<Book> myBooks = new List<Book>();
            myBooks.Add(lotr);
            myBooks.Add(frankenstein);
            myBooks.Add(fourteenNinetyOne);
            myBooks.Add(foreverWar);

            Library shawneePublicLibrary = new Library(myBooks, "Shawnee Public Library", "400 E. Shawnee Mission Parkway", "Shawnee", "KS", "74147");

            Library myPersonalBookshelf = new Library();
            myPersonalBookshelf.Books = myBooks;
            myPersonalBookshelf.City = "Kansas City";
            myPersonalBookshelf.LibraryName = "My personal book collection";
            myPersonalBookshelf.State = "MO";
            myPersonalBookshelf.Zip = "99999";
            myPersonalBookshelf.StreetAddress = "700 31st Street";

            Console.WriteLine("\n");
            Console.WriteLine(shawneePublicLibrary);
            Console.WriteLine("\n");
            Console.WriteLine(myPersonalBookshelf);

            //*****************

            Song immigrantSong = new Song("Led Zepplin", "Immigrant Song", 190);

            Song holdYouNow = new Song();
            holdYouNow.Artist = "Vampire Weekend";
            holdYouNow.Title = "Hold you now";
            holdYouNow.LengthInSeconds = 140;

            Console.WriteLine("\n");
            Console.WriteLine(immigrantSong);
            Console.WriteLine("\n");
            Console.WriteLine(holdYouNow);

            //*****************

            Song stairway = new Song("Led Zepplin", "Stairway to heaven", 400);
            Song jnyb = new Song("Vampire Weekend", "Jerusalem, New York, Berlin", 181);

            Song[] lz = { immigrantSong, stairway };
            Song[] vw = { holdYouNow, jnyb };

            Artist ledZeppHits = new Artist(lz, "Led Zepplin Greatest Hits", "Rock");
            Artist vampWeekend = new Artist(vw, "Vampire Weekend Presents", "Alt-Rock");

            Console.WriteLine("\n");
            Console.WriteLine(ledZeppHits);
            Console.WriteLine(vampWeekend);

            //************

            MotorHome winabango = new MotorHome("Winabango", "S-7", 1989, 4000, 3);
            MotorHome modifiedBus = new MotorHome();
            modifiedBus.Make = "School Bus";
            modifiedBus.Model = "modified by owner";
            modifiedBus.Year = 2000;
            modifiedBus.Weight = 8000;
            modifiedBus.NumberOfBeds = 6;

            Console.WriteLine("\n");
            Console.WriteLine(winabango);
            Console.WriteLine("\n");
            Console.WriteLine(modifiedBus);

            //************

            Truck fjordTough = new Truck("Ford", "F-150", 2003, 1500, 3500f);
            Truck scottsDadsTruck = new Truck();
            scottsDadsTruck.Make = "Chevy";
            scottsDadsTruck.Model = "S10";
            scottsDadsTruck.Year = 1988;
            scottsDadsTruck.Weight = 1200;
            scottsDadsTruck.LoadCapacityLbs = 2000f;

            Console.WriteLine("\n");
            Console.WriteLine(fjordTough);
            Console.WriteLine("\n");
            Console.WriteLine(scottsDadsTruck);
        }
    }
}
