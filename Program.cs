using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceApproval // Namespace declaration
{
    class Program // Class declaration
    {
        static void Main(string[] args) // Main method declaration
        {
            Console.WriteLine("Insurance Approval Program"); // Output message
            Console.WriteLine("What is your age?"); // Output message
            int userAge = Convert.ToInt32(Console.ReadLine()); // Convert userAge to int
            Console.WriteLine("Have you had a DUI? state y/n"); // Output message
            string duiResponse = Console.ReadLine(); // Read user input for DUI response
            bool hasDUI = duiResponse.ToLower() == "y"; // Convert duiBool to true if stated yes and false if stated n
            Console.WriteLine("How many speeding tickets do you have?"); // Output message
            int ticketsCount = Convert.ToInt32(Console.ReadLine()); // Convert ticketsCount to int

            bool userAgeBool = userAge >= 15; // Check if user's age is over 15
            bool hasNoDUI = !hasDUI; // Check if user has no DUI
            bool ticketsCountBool = ticketsCount <= 3; // Check if user has 3 or fewer speeding tickets

            bool qualified = (userAgeBool && hasNoDUI && ticketsCountBool); // Check if user is qualified based on all conditions

            // Output user's age, DUI status, tickets count, and qualification status
            Console.WriteLine($"Age: {userAge} \nDUI: {hasDUI} \nSpeeding tickets: {ticketsCount} \nQualified {qualified}");
            Console.ReadLine(); // Wait for user input before closing console window
        }
    }
}
