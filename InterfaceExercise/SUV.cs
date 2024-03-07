using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class SUV : IVehicle , ICompany
    {
        public int NumberOfSeats { get; set; } = 7;
        public bool AllWheelDrive { get; set; } = true;
        public int NumberOfWheels { get; set; } = 4;
        public int NumberOfDoors { get; set; } = 4;
        public bool Transmission { get; set; } = true;
        public string FuelSystem { get; set; } = "Gas";
        public string Make { get; set; } = "Toyota";
        public bool LegalCompliance { get; set; } = true;
        public bool ChangedGears {  get; set; }
        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} drives."); 
        }
        public void Reverse()
        {
            if (ChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} reverses.");
                ChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't reverse until we change gears.");
            }
        }
        public void Park()
        {
            if (ChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} parks.");
                ChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't park until we change gears.");
            }
        }
        public void ChangeGears(bool isChanged)
        {
            ChangedGears = isChanged;
        }
    }
}
