using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rem2024
{
    public class PrevisionClass
    {
        public int id { get; set; }
        public string forecastName { get; set; }
        public float forecastPercent { get; set; }

        public PrevisionClass() { }

        public PrevisionClass(int id, string forecastName, float forecastPercent)
        {
            this.id = id;
            this.forecastName = forecastName;
            this.forecastPercent = forecastPercent;
        }
    }
}
