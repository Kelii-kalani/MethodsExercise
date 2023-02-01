using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExercise
{
    internal class FirstExercise
    {
        public static void Story()
        {

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("Name a body part?");
            string bodyPart = Console.ReadLine();

            Console.WriteLine("Name a tool?");
            string tool = Console.ReadLine();

            Console.WriteLine("Who is your best friend?");
            string bestFriend = Console.ReadLine();

            Console.WriteLine("Name a room in your house?");
            string place = Console.ReadLine();

            Console.WriteLine($"Hello my name is Dr.{name}. I specialize in working on peoples {bodyPart}.\n" +
                    $"My best work was when my best friend {bestFriend} smashed their {bodyPart} in the door of their {place}.\n" +
                    $"All I had on me was a {tool} to fix his {bodyPart}. I found a few other things in their house to help \n" +
                    $"but boy did that {tool} do wonders!");
        }
    }
}
