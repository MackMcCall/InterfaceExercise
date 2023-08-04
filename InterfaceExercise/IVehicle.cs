using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal interface IVehicle
    {
        public int NumberOfWheels { get; set; }
        public string PaintColor { get; set; }
        public bool IsDriveable { get; set; }
        public string Model { get; set; }
    }
}
