using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs2019
{
    class Program
    {
        public struct Point
        {
            public double X { get; set; }
            public double Y { get; set; }
            public double Distance => Math.Sqrt(X * X + Y * Y);

            public override string ToString() =>
                $"({X}, {Y}) is {Distance} from the origin";
        }

        static void Main(string[] args)
        {
            Point p = new Point();
            p.X = 1.0;
            p.Y = 1.0;
            Console.WriteLine(p);
        }
    }
}
