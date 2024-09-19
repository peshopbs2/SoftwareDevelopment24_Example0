using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCExampleWithList
{
    public class CarContext
    {
        public List<Car> Cars { get; set; }
        public CarContext() { 
            Cars = new List<Car>();
        }
    }
}
