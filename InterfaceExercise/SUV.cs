using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class SUV: IVehicle , ICompany 
    {
        public SUV()
        {

        }
        public double EngineSize { get; set; } = 8;
        public string Make { get; set; } = "Toyota";
        public string Model { get; set; } = "Highlander";
        public int SeatCount { get; set; } = 7;
        public string CompanyName { get; set; } = "Toyota";
        public string Motto { get; set; } = "Let's Go Places";
        public bool HasChangedGears { get; set; }

        public int GatlingGunSize { get; set; } = 10;
        public int ArmorRating { get; set; } = 10;
        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} now driving forward . . .");
        }
        public void Reverse()
        {
            if (HasChangedGears == true)
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
            Console.WriteLine();
        }
        public void ChangeGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }
    }
}
