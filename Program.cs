using System;

namespace ObjectsAndStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create and compare Computer objects
            Computer myComputer = new Computer("Apple", "All-in-One", true);
            IBootUp myBootUp = myComputer;
            Console.WriteLine(myComputer.Equals(myBootUp));

            Computer myOtherComputer = new Computer("Apple", "All-in-One", true);
            Console.WriteLine(myComputer.Equals(myOtherComputer));

            // String manipulation and comparison
            string myString = myComputer.ToString();
            string myOtherString = myString;

            myString = "Ii";
            Console.WriteLine(myString);
            Console.WriteLine(myOtherString);

            Console.WriteLine(myString == myComputer.ToString());
            Console.WriteLine(myString == myOtherComputer.ToString());

            // Type and method checks
            Console.WriteLine(myComputer.GetType());
            Console.WriteLine(myBootUp.GetType());

            myOtherComputer.PowerOnOff();
            Console.WriteLine(myString == myOtherComputer.ToString());

            Console.WriteLine(myString);
            Console.WriteLine(myOtherComputer.ToString());

            // String methods
            Console.WriteLine(myString.Contains('i'));
            Console.WriteLine(myString.ToUpper());
        }
    }
}