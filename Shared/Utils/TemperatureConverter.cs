using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Utils
{
    public class TemperatureConverter
    {
        private TemperatureConverter() { }

        public static string GetSummary(int temp)
        {
            var summary = "Mild";
            if (temp >= 32)
            {
                summary = "Hot";
            }
            else if (temp <= 16 && temp > 0)
            {
                summary = "Cold";
            }
            else if (temp <= 0)
            {
                summary = "Freezing";
            }
            return summary;
        }
    }
}
