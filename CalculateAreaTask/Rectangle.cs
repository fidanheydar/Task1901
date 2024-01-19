using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateAreaTask
{
    public class Rectangle : Shape, IShape
    {
        public double Height;
        public double Width;

        public void CalculateArea()
        {
            Console.WriteLine("Area of Rectangle:" + (Height * Width));
        }
        //with abstraction
        //public override void CalculateArea()
        //{
        //    Console.WriteLine("Area of Rectangle:" + (Height * Width));
        //}
    }
}
