using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Truck : Vehicle
    {
        //props
        public float LoadCapacityLbs { get; set; }

        //ctor
        public Truck(string make, string model, int year, int weight, float loadCapacityLbs) : base(make, model, year, weight)
        {
            LoadCapacityLbs = loadCapacityLbs;
        }

        public Truck() { }

        public override string ToString()
        {
            return string.Format("A {0} {1} can carry up to  {2} lbs.", Make, Model, LoadCapacityLbs);
        }
    }
}
