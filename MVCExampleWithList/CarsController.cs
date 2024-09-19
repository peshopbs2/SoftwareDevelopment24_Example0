using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCExampleWithList
{
    public class CarsController
    {
        private CarContext context = new CarContext();

        public void Add(Car car)
        {
            context.Cars.Add(car);
        }

        public Car GetCarById(int id)
        {
            return context.Cars
                .Where(item => item.Id == id)
                .First();
        }

        public List<Car> GetCars()
        {
            return context.Cars;
        }

    }
}
