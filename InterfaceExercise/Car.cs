using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Car : IVehicle, ICompany
    {
        public int NumberOfWheels { get; set; }
        public string PaintColor { get; set; }
        public bool IsDriveable { get; set; }
        public string Model { get; set; }
        public string Logo { get; set; }
        public string Audience { get; set; }

        //Car Specific
        public double NumOfDoors { get; set; }
        public bool HasTrunk { get; set; }

        public void CarDetails()
        {
            Console.WriteLine($"This is the {this.PaintColor} {this.NumOfDoors}-door {this.Model}. It has a {this.Logo} for the logo.");
            Console.WriteLine($"It has {this.NumberOfWheels} wheels and {(this.IsDriveable ? "is" : "is not")} driveable.");
            Console.WriteLine($"They are typically for {this.Audience} and they {(this.HasTrunk ? "do" : "do not")} have a trunk.");
        }
    }
}
