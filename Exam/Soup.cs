using System;
using System.Collections.Generic;
using System.Text;

namespace Exam
{
    class Soup : Product
    {
        public Soup() : base(Category.Soups)
        {

        }

        public override double CalculateCalories()
        {
            return 0f;
        }
    }
}
