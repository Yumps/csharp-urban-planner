using System;

namespace csharp_urban_planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building FiveOneTwoEigth = new Building("512 8th Avenue")
            {
                Width = 26.9,
                Depth = 23.4,
                Stories = 6,
            };
            FiveOneTwoEigth.Construct("Logan");
            FiveOneTwoEigth.Purchase("James");

            Building TwoOneStreetBuilding = new Building("213 St Building")
            {
                Width = 40.9,
                Depth = 58.4,
                Stories = 9,
            };
            TwoOneStreetBuilding.Construct("Charles");
            TwoOneStreetBuilding.Purchase("Joe");

            City Extremeville = new City()
            {
                Name = "Extremeville",
                Mayor = "John Marston",
                Year = 2015
            };
            
            Extremeville.Buildings.Add(TwoOneStreetBuilding);
            Extremeville.Buildings.Add(FiveOneTwoEigth);

            Console.WriteLine($"City: {Extremeville.Name}");
            Console.WriteLine($"Mayor of City: {Extremeville.Mayor}");
            Console.WriteLine($"Year it was formed: {Extremeville.Year}");
            foreach(Building building in Extremeville.Buildings)
            {
                building.info();
            }

        }
    }
}
