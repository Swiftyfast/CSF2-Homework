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
        }
    }
}
