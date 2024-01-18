using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    internal class ChinaCity:City
    {

        public override int CityPopulation
        {
            get
            {
                return Population;
            }
            set
            {
                if (value >= 100000)
                    Population = value;
            }
        }
    }
}
