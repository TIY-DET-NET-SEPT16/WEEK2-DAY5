using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridaySample
{
    class Program
    {
        static void Main(string[] args)
        {
            bool addAnother = true;
            List<SomeCoolThing> coolList = new List<SomeCoolThing>();

            while(addAnother)
            {
                SomeCoolThing theThing = new SomeCoolThing();

                Console.WriteLine("What is the value of the first property?");
                string response = Console.ReadLine();
                theThing.MyProperty1 = response;

                Console.WriteLine("What is the value of the second property?");
                string anotherResponse = Console.ReadLine();

                theThing.MyProperty2 = anotherResponse;

                coolList.Add(theThing);

                Console.WriteLine("Would you like to create another cool thing? (y/n)");
                string answer = Console.ReadLine();

                if (answer == "y")
                {
                    addAnother = true;
                }
                else
                {
                    addAnother = false;
                }
            }

            for(int i = 0; i < coolList.Count; i++)
            {
                Console.WriteLine(string.Format("My Cool thing {0} property1 = {1}, property = {2}", 
                    i, coolList[i].MyProperty1, coolList[i].MyProperty2));
            }

            Console.ReadLine();
        }
    }
}
