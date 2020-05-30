using System;
using System.Collections.Generic;
using System.Text;

namespace Exam
{
    class Drink : Product
    {
        public Drink() : base(Category.Baverages)
        {

        }

        public override double CalculateCalories()
        {
            return WeightVolume * 1.5;
        }
    }
}
