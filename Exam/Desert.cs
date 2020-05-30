using System;
using System.Collections.Generic;
using System.Text;

namespace Exam
{
    class Desert : Product
    {
        public Desert() : base(Category.Deserts) 
        {

        }

        public override double CalculateCalories()
        {
          return   WeightVolume * 3;
        }
    }
}
