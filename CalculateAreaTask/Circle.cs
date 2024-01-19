using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateAreaTask
{
    public class Circle : Shape, IShape
    {
        public double Radius;

        public void CalculateArea()
        {
            Console.WriteLine("Area of circle:"+3.14 * (Radius*Radius));
        }
        //with abstraction
        //public override void CalculateArea()
        //{
        //    Cnsole.Writeline("Area of circle:" + 3.14 * (Radius * Radius));
        //}
    }
}
