using System;
using System.Collections.Generic;
using System.Text;

namespace Cities.Comparers  
{
    public class AreaComparer : IComparer<City>
    {
        //TODO - COMPLETE  results in sorting by land area, from largest to smallest

        public int Compare(City x, City y)
        {
            // we are comparing "double" type values 
            // so use "CompareTo"
            // we want to sort largest to smallest so use y compared to x
            return y.Area.CompareTo(x.Area);
        }
    }
}
