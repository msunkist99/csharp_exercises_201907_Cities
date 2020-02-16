using System;
using System.Collections.Generic;
using Cities.Comparers;

namespace Cities
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<City> cities = CityDataImporter.LoadData();

            // TODO COMPLETE Swap out comparers as desired
            //IComparer<City> comparer = new NameComparer();
            //IComparer<City> comparer = new AreaComparer();
            //IComparer<City> comparer = new PopulationComparer();
            //IComparer<City> comparer = new StateComparer();

            CompoundComparer compoundComparer = new CompoundComparer();

            // by decending population - second sort key
            // within ascending state name - first sort key
            compoundComparer.Comparers.Add(new StateComparer());
            compoundComparer.Comparers.Add(new PopulationComparer());

            cities.Sort(compoundComparer);

            PrintCities(cities);

            Console.ReadLine();
        }

        private static void PrintCities(List<City> cities)
        {
            Console.WriteLine(City.GetTableHeader());

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

        }
    }
}
