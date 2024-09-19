using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCExampleWithList
{
    public class Car
    {
        private static int counter = 1;
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public string Fuel { get; set; }

        public Car()
        {
            Id = counter;
            counter++;
        }

        public override string ToString()
        {
            return $"{Id}. {Brand} {Model} {Fuel} ({Year})";
        }
    }
}
