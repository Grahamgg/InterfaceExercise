using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public Car()
        {

        }
        public double EngineSize { get; set; } = 4.6;
        public string Make { get; set; } = "Ford";
        public string Model { get; set; } = "Generic";
        public int SeatCount { get; set; } = 4;
        public string CompanyName { get; set; } = "Generic";
        public string Motto { get; set; } = "Generic";
        public bool HasChangedGears { get; set; }
        public int LazerSize { get; set; } = 20;
        public int ShieldSize { get; set; } = 10;

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} now driving forward . . .");
        }
        public void Reverse()
        {
            if(HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now reversing . . .");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't reverse until we changed gears");
            }
            
        }
        public void Park()
        {
           
        }
        public void ChangeGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }
    }
}
