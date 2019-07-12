using System;

namespace csharp_urban_planner
{
    public class Building
    {
        private string _designer;
        private DateTime _dateConstructed;
        private string _address;
        private string _owner;
        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Volume
        {
            get{
            return Width * Depth * (3 * Stories);
            }
            
        }
        public Building(string Address)
        {
            _address = Address;
        }
        public void Construct(string designer)
        {
            _designer = designer;
            _dateConstructed = DateTime.Now;
        }
        public void Purchase(string name){
            _owner = name;
        }
        public void info()
        {
            Console.WriteLine($"{_address}");
            Console.WriteLine($"------------");
            Console.WriteLine($"Designed by {_designer}");
            Console.WriteLine($"Constructed on {_dateConstructed}");
            Console.WriteLine($"Owned by {_owner}");
            Console.WriteLine($"{Volume}");
        }
    }
}