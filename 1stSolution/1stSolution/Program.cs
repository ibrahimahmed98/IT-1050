using System;

namespace stSolution
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            System.Console.Write("First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Middle Initial: ");
            string middleInitial = Console.ReadLine();
            Console.Write("last Name: ");
            string lastName = Console.ReadLine();

            string fullName = firstName + " " + middleInitial + " " + lastName;

            Console.Write("Height in feet: ");
            int heightFeet = int.Parse(Console.ReadLine());
            Console.Write("Height in Inches: ");
            double heightInches = double.Parse(Console.ReadLine());

            double heightCentimeters = (heightFeet * 12 + heightInches) * 2.54;

            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Citizen? (y/n) : ");
            bool isCitiznen = Console.ReadLine().ToLower().StartsWith("y");

            bool canVote = isCitiznen && age >= 18;

            Console.WriteLine(fullName);
            Console.WriteLine(heightCentimeters);
            Console.WriteLine(canVote);
        }
    }
}
