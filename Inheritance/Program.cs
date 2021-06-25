using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Bird murkrow = new Bird()
            {
                Name = "Murkrow",
                Age = 3,
                Legs = 2,
                HasBackbone = true,
                IsWarmBlooded = true,
                HasFeathers = true,
                Wings = 2,
                Type = "flying",

            };

            Console.WriteLine($"{murkrow.Name} is an {murkrow.Type} pokemon which is {murkrow.Age} years old and has it's normal number of {murkrow.Legs} legs and {murkrow.Wings} wings.");

            Console.WriteLine($"If you are wondering if {murkrow.Name} has the 3 of these a bird should have, backbone, being warm blooded and having feathers, then it's {murkrow.HasBackbone}, {murkrow.IsWarmBlooded}, and {murkrow.HasFeathers}");
            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            Reptile gible = new Reptile()
            {
                Name = "Gible",
                Age = 4,
                Legs = 2,
                HasBackbone = true,
                IsColdBlooded = true,
                HasScales = true,
                Environment = "geothermal areas",
                Defense = "chomping and fighting",

            };

            Console.WriteLine($"{gible.Name} is an agressive pokemon that does {gible.Defense} also which is an average {gible.Age} years old and has a number of {gible.Legs} legs and lives in an {gible.Environment}.");

            Console.WriteLine($"If you are wondering if {gible.Name} has the 3 of these a dragon type should have, backbone, being cold blooded and having scales, then it's {gible.HasBackbone}, {gible.IsColdBlooded}, and {gible.HasScales}");
           

        }
    }
}
