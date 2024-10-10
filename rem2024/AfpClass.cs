using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rem2024
{
    public class AfpClass
    {

        public int id { get; set; }
        public string afpName { get; set; }
        public float afpPercent { get; set; }

        public AfpClass() { }

        public AfpClass(int id, string afpName, float afpPercent)
        {
            this.id = id;
            this.afpName = afpName;
            this.afpPercent = afpPercent;
        }   
    }
}
