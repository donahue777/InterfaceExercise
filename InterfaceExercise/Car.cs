using System;

namespace InterfaceExercise
{
    public class Car : IVehicle , ICompany
    {
        public bool Sedan {  get; set; } = true;
        public bool BuiltForSpeed {  get; set; } = false;
        public int NumberOfWheels { get; set; } = 4;
        public int NumberOfDoors { get; set; } = 4;
        public bool Transmission { get; set; } = true;
        public string FuelSystem { get; set; } = "Hydrogen";
        public string Make { get; set; } = "Toyota";
        public bool LegalCompliance { get; set; } = true;
        public bool ChangedGears { get; set; }
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
