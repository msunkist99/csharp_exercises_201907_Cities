using System;
using System.Collections.Generic;
using System.Text;

namespace Cities.Comparers
{
    public class CompoundComparer : IComparer<City>
    {
        public IList<IComparer<City>> Comparers { get; set; }

        public CompoundComparer()
        {
            // initialize the Comparers IList property when creating CompoundComparer (in the constructor)
            Comparers = new List<IComparer<City>>();
        }

        public int Compare(City x, City y)
        {
            int result = 0;

            result = Comparers[0].Compare(x, y);

            // if result == 0 then sort keys are equal
            // so you know need to sort on the second sort key
            if (result == 0)
            {
                result = Comparers[1].Compare(x, y);
            }

            return result;
        }
    }
}
