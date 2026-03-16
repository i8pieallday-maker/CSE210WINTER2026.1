// using System;
// using System.Globalization;
// using System.Security.Cryptography;
// using System.Collections.Generic;

// class Program2
// {
//     public static void Main(string[] args)
//     {
//         List<int> numbers = new List<int>();
//         int input = -1;

//         while (input != 0)
//         {
//             Console.WriteLine("Enter a list of numbers, 0 is illegal though\n");
//             Console.Write($"Enter number: ");
//             string response = Console.ReadLine();

//             if (int.TryParse(response, out input))
//             {
//                 numbers.Add(input);
//             }
//             else
//             {
//                 Console.WriteLine("no try an actual number");
//             }

//             int total = 0;
//             foreach (int n in numbers)
//             {
//                 total += n;
//             }

//             Console.WriteLine($"Sum = {total}");

//         }
//     }
    
// }