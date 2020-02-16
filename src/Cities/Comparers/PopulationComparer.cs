using System;
using System.Collections.Generic;
using System.Text;

namespace Cities.Comparers  
{
    public class PopulationComparer : IComparer<City>
    {
        //TODO - COMPLETE results in sorting by population, from largest to smallest
        public int Compare(City x, City y)
        {
            // we are comparing "int" type values 
            // so use "CompareTo"
            // we want to sort largest to smallest so use y compared to x
            return y.Population.CompareTo(x.Population);
        }

    }
}
