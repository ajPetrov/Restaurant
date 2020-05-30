using System;
using System.Collections.Generic;
using System.Text;

namespace Exam
{
    public abstract class Product
    {
        

        protected Product(Category category)
        {
            this.Category = category;
        }

        public Category Category { get; set; }

        public decimal Price { get; set; }

        public int WeightVolume { get; set; }

        public string Name { get; set; }

        public int OrderedCount { get; set; }

        public decimal CalculatePrice()
        {
            return OrderedCount * Price;
        }

        public abstract double CalculateCalories();
        
    }
}
