using System;
using System.Collections.Generic;
using System.Text;

namespace Exam
{
    class Salad : Product
    {
        public Salad() : base(Category.Salads)
        {

        }

        public override double CalculateCalories()
        {
            return 0f;
        }
    }
}
