using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTest.Models
{
    public class Circle: Shape
    {
        public override double GetArea(int x, int y = 0)
        {
            double result = (3.14) * (x*x);
            return result;
        }
    }
}
