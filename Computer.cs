using System;

namespace ObjectsAndStrings
{
    internal class Computer : IBootUp
    {
        // Properties for the computer's state, brand, and type
        public bool IsOn { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }

        // Constructor to initialize the computer's attributes
        public Computer(string brand, string type, bool isOn)
        {
            Brand = brand;
            Type = type;
            IsOn = isOn;
        }

        // Method to toggle the power state of the computer
        public void PowerOnOff()
        {
            IsOn = !IsOn;
            if (IsOn)
            {
                Console.WriteLine("The computer is booting up!");
            }
            else
            {
                Console.WriteLine("The computer is shutting down!");
            }
        }

        // Override ToString to provide a custom description of the computer
        public override string ToString()
        {
            return $"The computer is made by {Brand} and is a(n) {Type} computer!";
        }
    }
}
