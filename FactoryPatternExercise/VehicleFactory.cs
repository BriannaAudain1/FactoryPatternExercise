using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise
{
    public static class VehicleFactory 
    {
       public static IVehicle GetVehicle(string wheels)
        {
            switch(wheels.ToLower())
            {
                case "4":
                case "four":
                    return new Car();
                case "2":
                case "two":
                    return new MotorCycle();
                default:
                    return new Car();
            }
        }
    }
}
