using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsOfMeasurement
{
    class Measurements
    {
        public double ConvertUnits(double number, string fromUnitOfMeasurement, string toUnitOfMeasurement)
        {
            double result = 0;
            if (fromUnitOfMeasurement == "m")
            {
                if (toUnitOfMeasurement == "cm")
                {
                    result = number * 100;
                }
                else if (toUnitOfMeasurement == "mm")
                {
                    result = number * 1000;
                }
            }

            else if (fromUnitOfMeasurement == "mm")
            {
                if (toUnitOfMeasurement == "m")
                {
                    result = number / 1000;
                }
                else if (toUnitOfMeasurement == "cm")
                {
                    result = number / 10; ;
                }
            }
            else if (fromUnitOfMeasurement == "cm")
            {
                if (toUnitOfMeasurement == "mm")
                {
                    result = number * 10;
                }
                else if (toUnitOfMeasurement == "m")
                {
                    result = number / 100;
                }
            }

            return result;
        }
    }
}
