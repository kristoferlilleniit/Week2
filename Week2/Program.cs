using System;

namespace Week2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good morning!");
            Console.WriteLine("What's your name?");
            string Name;
            Name = Console.ReadLine();
            Console.WriteLine("Hello, " + Name);
            Console.WriteLine("How old are you?");
            string UserInput;
            UserInput = Console.ReadLine();
            int HowOldAreYou;
            // parsing string to interger (number)
            HowOldAreYou = Int32.Parse(UserInput);
            int YearOfBirth = 2020 - HowOldAreYou;
            Console.WriteLine("You were born in " + YearOfBirth);
        }
    }
}
