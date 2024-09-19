using MVCExampleWithList;

string command = Console.ReadLine();
CarsController controller = new CarsController();

while (command != "stop")
{
    if (command == "Add")
    {
        string brand = Console.ReadLine();
        string model = Console.ReadLine();
        string color = Console.ReadLine();
        int year = int.Parse(Console.ReadLine());
        string fuel = Console.ReadLine();
        Car car = new Car()
        {
            Brand = brand,
            Model = model,
            Color = color,
            Year = year,
            Fuel = fuel
        };
        controller.Add(car);
        Console.WriteLine("Car added!");
    }
    else if (command == "GetById")
    {
        int id = int.Parse(Console.ReadLine());
        var car = controller.GetCarById(id);
        Console.WriteLine(car);
    }
    else if (command == "GetAll")
    {
        var cars = controller.GetCars();
        foreach (var car in cars)
        {
            Console.WriteLine(car);
        }
    }

    command = Console.ReadLine(); //!!!!
}
