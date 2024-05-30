using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Shreya_Naidoo_ST10195567_PROG6221_Part_2
{
    public class ingredients
    {
        public string Name { get; set; }
        public double Quantity { get; set; }
        public string Unit { get; set; }
        private double OriginalQuantity { get; set; }

        // Constructor to initialize the ingredient properties.
        public ingredients(string name, double quantity, string unit)
        {
            Name = name;
            Quantity = quantity;
            OriginalQuantity = quantity;
            Unit = unit;
        }

        // Method to scale the ingredient quantity by a factor.
        public void Scale(double factor)
        {
            Quantity = OriginalQuantity * factor;
        }

        // Method to reset the ingredient quantity to its original value.
        public void Reset()
        {
            Quantity = OriginalQuantity;
        }

        // Overrides the default ToString method for neat output.
        public override string ToString()
        {
            return $"{Quantity} {Unit} of {Name}";
        }

    }
    //part 2 
    
    // Properties
    public string Name { get; set; }
    public int Calories { get; set; }
    public string FoodGroup { get; set; }

    // Constructor
    public ingredients (string name, int calories, string foodGroup)
    {
        Name = name;
        Calories = calories;
        FoodGroup = foodGroup;
    }
}
}
// Code Attribution
// This code is taken from Pro C# 10 with .net 6 Foundational principles and practices in programming
// Eleventh edition 
// By Andrew Troelsen and Phil Japiske
