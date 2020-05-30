using System;
using System.Collections.Generic;
using System.Text;

namespace Exam
{
    public static class ProductFactory
    {
        public static Product GetProduct(string str)
        {
            var splitted = str.Split(",");
            var category = GetCategory(splitted[0].Trim());
            var name = splitted[1].TrimStart();
            var weightVolume = int.Parse(splitted[2].TrimStart());
            var price = decimal.Parse(splitted[3].TrimStart());
            Product p = null;
            switch (category)
            {
                case Category.Salads:
                    p = new Salad()
                    {
                        Name = name,
                        WeightVolume = weightVolume,
                        Price = price
                    };
                    break;

                case Category.MainDish:
                    p = new MainDish()
                    {
                        Name = name,
                        WeightVolume = weightVolume,
                        Price = price
                    };
                    break;
                case Category.Soups:
                    p = new Soup()
                    {
                        Name = name,
                        WeightVolume = weightVolume,
                        Price = price
                    };
                    break;
                case Category.Deserts:
                    p = new Desert()
                    {
                        Name = name,
                        WeightVolume = weightVolume,
                        Price = price
                    };
                    break;
                case Category.Baverages:
                    p = new Drink()
                    {
                        Name = name,
                        WeightVolume = weightVolume,
                        Price = price
                    };
                    break;
            }

            return p;
        }

        private static Category GetCategory(string cat)
        {
            switch (cat.ToLower())
            {
                case "супи": return Category.Soups;
                case "салати": return Category.Salads;
                case "основно ястие": return Category.MainDish;
                case "напитки": return Category.Baverages;
                case "десерти": return Category.Deserts;
                default: throw new Exception("Няма такава категория сори :)");
            }
        }
    }
}
