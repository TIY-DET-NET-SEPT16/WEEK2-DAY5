using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridaySample
{
    public class SomeCoolThing
    {
        string myProperty1;
        string myProperty2;

        public string MyProperty1
        {
            get
            {
                return myProperty1;
            }

            set
            {
                myProperty1 = value;
            }
        }

        public string MyProperty2
        {
            get
            {
                return myProperty2;
            }

            set
            {
                myProperty2 = value;
            }
        }
    }
}
