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
            //Set the initial value to true so the while loop executes at least once
            bool addAnother = true;

            //Create the list to hold all the cool things
            List<SomeCoolThing> coolList = new List<SomeCoolThing>();

            //While addAnother is true do all this again
            while(addAnother)
            {
                //Create the cool thing object
                SomeCoolThing theThing = new SomeCoolThing();

                //Ask the user for the value
                Console.WriteLine("What is the value of the first property?");
                //Read the value into a temporary variable
                string response = Console.ReadLine();
                //Put the user's response into the object
                theThing.MyProperty1 = response;

                //Ask the user for the value
                Console.WriteLine("What is the value of the second property?");
                //Read the value into a temporary variable
                string anotherResponse = Console.ReadLine();
                //Put the user's response into the object
                theThing.MyProperty2 = anotherResponse;

                //Add the object to the list
                coolList.Add(theThing);

                //Determine if the user wants to do it all again
                Console.WriteLine("Would you like to create another cool thing? (y/n)");
                //Get the user's response
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

            //Now that we are done looping to get the user's response, write out the things
            for(int i = 0; i < coolList.Count; i++)
            {
                Console.WriteLine(string.Format("My Cool thing {0} property1 = {1}, property = {2}",
                    i, coolList[i].MyProperty1, coolList[i].MyProperty2));
            }

            Console.ReadLine();
        }
    }
}
