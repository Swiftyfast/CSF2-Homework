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
            Student ferdinand = new Student();
            ferdinand.LastName = "Ferdinand";
            ferdinand.FirstName = "Franz";

            Console.WriteLine(ferdinand);

            Vehicle falcon = new Vehicle("Corellian Corvette", "YT-1300", 5, 30000);

            Console.WriteLine(falcon);

            Login myActualLogin = new Login("myName", "12345");

            Console.WriteLine(myActualLogin);

            ContactInfo myInfo = new ContactInfo("3180 Main Street", "Kansas City", "KS", "45825", "913-555-5885", "email@email.com");

            Console.WriteLine(myInfo);
        }
    }
}
