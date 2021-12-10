using System;

namespace ReverseOrderOfWords

{
    class Reverse

    {
        static void Main()
        {
            Console.Write("input String:");
            string inputString = Console.ReadLine();  
            string[] splitArray = inputString.Split(' '); 
            Array.Reverse(splitArray); 
            Console.Write("Output:");

            foreach (string str in splitArray)  
            Console.Write(str + " ");
        }
    }
}
