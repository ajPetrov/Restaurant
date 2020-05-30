using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            var products = new Dictionary<string, Product>();
            var tables = new Dictionary<int, List<Product>>();
            while (exit == false)
            {
                var command = Console.ReadLine();
                if (command.ToLower() == "изход")
                {
                    exit = true;
                }
                else if (command.ToLower() == "продажби")
                {

                }
                else
                {
                    var splitted = command.Split(",");
                    if (splitted[0].Trim().All(char.IsDigit))
                    {
                        //Order
                        var table = 
                    }
                    else
                    {
                        //add product
                        var product = ProductFactory.GetProduct(command);
                        products.Add(product.Name, product);
                    }
                }

            }
        }
    }
}
