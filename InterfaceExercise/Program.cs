using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Schema;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Car altima = new Car()
            {
                NumberOfWheels = 4,
                PaintColor = "Gray",
                IsDriveable = true,
                Model = "Altima",
                Logo = "Nissan in a circle",
                Audience = "average sedan owners",
                NumOfDoors = 4,
                HasTrunk = true
            };

            Truck ranger = new Truck()
            {
                NumberOfWheels = 4,
                PaintColor = "Red",
                IsDriveable = false,
                Model = "Ranger",
                Logo = "cursive ford",
                Audience = "people who like little trucks",
                BedLength = 72,
                Torque = 150
            };

            SUV explorer = new SUV()
            {
                NumberOfWheels = 4,
                PaintColor = "White",
                IsDriveable = true,
                Model = "Explorer",
                Logo = "cursive ford",
                Audience = "suburban moms of more than 3",
                CargoCapacity = "everyone and everything",
                NumOfSeats = 8
            };


            altima.CarDetails();
            Console.WriteLine("\nOn to the next one...\n");
            
            ranger.TruckDetails();
            Console.WriteLine("\nOn to the next one...\n");
            
            explorer.SuvDetails();
        }
    }
}
