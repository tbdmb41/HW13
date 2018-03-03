using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FleetSim.Objects;
namespace FleetSim
{
    class Program
    {
        public static List<Car> LoadCars()
        {
            var theCars = new List<Car>
                                    {
                                    new Car()
                                    {
                                    VIN = Guid.Empty,
                                    Color = "chartreruse",
                                    LastServicedMileage = 0,
                                    LastServicedDate = DateTime parsedDate = DateTime.Parse(dateInput);
                                        Console.WriteLine(parsedDate);,
                                    Mileage = 0,
                                    Model = "Honda Civic",
                                    ModelYear = 1993,
                                    },
                                        new Car()
                                        {
                                        VIN = Guid.Empty,
                                        Color = "FresshFigs",
                                        LastServicedMileage = 0,
                                        LastServicedDate = DateTime parsedDate = DateTime.Parse(dateInput);
                                            Console.WriteLine(parsedDate);,
                                        Mileage = 0,
                                        Model = "Crown Victoria",
                                        ModelYear = 1995
                                        },
                                            new Car()
                                            {
                                            VIN = Guid.Empty,
                                            Color = "PismoDunes",
                                            LastServicedMileage = 0,
                                            LastServicedDate = DateTime parsedDate = DateTime.Parse(dateInput);
                                                Console.WriteLine(parsedDate);,
                                            Mileage = 0,
                                            Model = "Toyota Camry",
                                            ModelYear = 1991
                                            },
                                                new Car()
                                                {
                                                VIN = Guid.Empty,
                                                Color = "YesterdaysGreen",
                                                LastServicedMileage = 0,
                                                LastServicedDate = DateTime parsedDate = DateTime.Parse(dateInput);
                                                    Console.WriteLine(parsedDate);,
                                                Mileage = 0,
                                                Model = "Jalopy",
                                                ModelYear = 2018
                                                },
                                                    new Car()
                                                    {
                                                    VIN = Guid.Empty,
                                                    Color = "Flaming Hot Magma",
                                                    LastServicedMileage = 0,
                                                    LastServicedDate = DateTime parsedDate = DateTime.Parse(dateInput);
                                                        Console.WriteLine(parsedDate);,
                                                    Mileage = 0,
                                                    Model = "AMC Gremlin",
                                                    ModelYear = 1970
                                                    },
                                                    };
foreach (Car theCar in theCars)
{
Console.WriteLine(theCar.Model + " " + theCar.ModelYear);
}
return theCars;
}
                        public static int getRandomNumber()
                        {
                         Random rnd = new Random();
                         int randomNumber = rnd.Next(5000, 15001);
                         return randomNumber;
                        }
static void Main(string[] args)
{
List<Car> carList = LoadCars();//creates & loads list of Cars; and returns it
byte i = 0;
while (i < 10)
{
foreach (var car in carList)
{
int miles = getRandomNumber();//generates a random # between 5000-15,000
car.Mileage += miles;
}
                             i++;
}

                    Console.ReadKey();


        }
    }
}