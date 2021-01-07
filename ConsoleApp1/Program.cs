using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net.Http.Headers;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int fahrenheit = 94;

            decimal celsius = (fahrenheit - 32);
            celsius = celsius * 5 / 9;

            Console.WriteLine($"The Temperature is {celsius}°C");


            //-------------------------------------------------------------------------------

            int firstValue = 500;
            int secondValue = 600;
            int largerValue = System.Math.Max(firstValue, secondValue);

            Console.WriteLine(largerValue);

            Console.WriteLine("This program runs in \"" + Directory.GetCurrentDirectory() + "\"");

            DirectoryInfo createdDirectory = Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), "TestDirectory"));
            Console.WriteLine($"Created \"{createdDirectory.ToString()}\" directory\n");


            string fileName = "freshlyCreatedFile.txt";
            string testFilePath = Path.Combine(Directory.GetCurrentDirectory(), fileName);

            File.WriteAllText(testFilePath, "Your Mum");

            Console.WriteLine("File \"" + fileName + "\" contains Text: \n" + File.ReadAllText(testFilePath).PadLeft(20));
            Console.WriteLine("\nDo you want to add something?");

            string input = Console.ReadLine();
            File.AppendAllText(testFilePath, input);

            Console.WriteLine("File \"" + fileName + "\" now contains: \n" + File.ReadAllText(testFilePath));
            Console.WriteLine();


            Random random = new Random();
            Console.WriteLine("It rolled: " + (random.Next(100) % 2 == 1 ? "Tails" : "Heads"));

            string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

            string[] orders = orderStream.Split(",");
            List<string> fraudulentOrders = new List<string>();

            foreach (string order in orders)
            {
                if (order.StartsWith("B"))
                {
                    Console.WriteLine(order);
                }
            }

            Console.WriteLine($"Price: {orderStream:C}");

            //---------------------------------------------------------------------------------------

            Console.WriteLine($"");
            Console.WriteLine($"");
            Console.WriteLine($"");
            Console.WriteLine($"");
            

            string customerName = "Mr. Jones";

            string currentProduct = "Magic Yield";
            int currentShares = 2975000;
            decimal currentReturn = 0.1275m;
            decimal currentProfit = 55000000.0m;

            string newProduct = "Glorious Future";
            decimal newReturn = 0.13125m;
            decimal newProfit = 63000000.0m;


            Console.WriteLine($"Dear {customerName},");
            Console.WriteLine($"");
            Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.");
            Console.WriteLine($"");
            Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P2}.");
            Console.WriteLine($"");
            Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P2}.  Given your current volume, your potential profit would be {newProfit:C}.");
            Console.WriteLine($"");
            Console.WriteLine("Here's a quick comparison:\n");

            string comparisonMessage = $"{currentProduct.PadLeft(15)} {currentReturn.ToString().PadLeft(18):P2} {currentProfit.ToString().PadLeft(22):C}\n" +
                                       $"{newProduct.PadLeft(15)} {newReturn.ToString().PadLeft(18):P2} {newProfit.ToString().PadLeft(22):C}";
            
            Console.WriteLine(comparisonMessage);


        }
    }
}
