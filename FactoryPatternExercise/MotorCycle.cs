using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise
{
    public class MotorCycle : IVehicle 
    {
        public MotorCycle()
        {
            Console.WriteLine("Building a new Motorcycle!");
        }

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} is now driving");
        }
    }
}
