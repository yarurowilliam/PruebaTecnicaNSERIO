using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTest.Models
{
    public class Rectangle : Shape
    {
        public override double GetArea(int x, int y)
        {
            double result = x * y;
            return result;
        }
    }
}
