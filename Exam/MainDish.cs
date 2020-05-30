using System;
using System.Collections.Generic;
using System.Text;

namespace Exam
{
    public class MainDish : Product
    {
        public MainDish() : base(Category.MainDish)
        {

        }
        public override double CalculateCalories()
        {
            return WeightVolume;
        }
    }
}
