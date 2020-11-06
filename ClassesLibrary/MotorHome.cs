using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class MotorHome : Vehicle
    {
        //props
        public int NumberOfBeds { get; set; }

        //ctor
        public MotorHome(string make, string model, int year, float weight, int numberOfBeds) : base(make, model, year, weight)
        {
            NumberOfBeds = numberOfBeds;
        }

        public MotorHome() { }

        public override string ToString()
        {
            return string.Format("A {0} {1} has {2} beds you can sleep in.", Make, Model, NumberOfBeds);
        }
    }
}
