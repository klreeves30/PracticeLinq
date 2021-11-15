using System;
using System.Linq;
using System.Collections.Generic;

namespace PracticeLinq
{
    class Program
    {
        /// Created a list for video games
        /// created a variable "lengthOfNames by using Lambad expression to get order and length to list"
        /// created a foreach loop in list to print out list of name by length in decending order.

        static void Main(string[] args)
        {
            List<string> listOfGames = new List<string> { "Madden", "Resident Evil", "NBA 2K", "PGA Golf" };

            var lengthOfNames = listOfGames.OrderByDescending(name => name.Length).ToList();

            foreach (var i in lengthOfNames)
            {
                Console.WriteLine(i);
            }

        }
    }
}
