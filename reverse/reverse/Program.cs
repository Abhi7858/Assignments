/*
Problem Statement:- How to reverse the order of words in a given string?
input:- Welcome to Csharp corner
output:- corner Csharp to Welcome
 */

using System;

namespace reverse

{
    class Reverse

    {
        static void Main()

        {
            Console.Write("input String:");
            string inp = Console.ReadLine();  // Takes input string from user.
            string[] arr = inp.Split(' '); // The string is splitted i.e converts into substring and stored in string array. 
            Array.Reverse(arr); // Reverse method Reverses the order of the elements and stores in that array implicitly.
            Console.Write("Output:");

            foreach (string str in arr)  // prints each substring from reversed string array
            {
                Console.Write(str + " ");
            }

        }

    }

}
