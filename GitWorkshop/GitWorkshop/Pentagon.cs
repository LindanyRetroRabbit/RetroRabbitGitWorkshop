using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitWorkshop
{
    class Pentagon
    {
        double side = 0;

        public void AreaPentagon()
        {
            double area_pentagon = 0;
            area_pentagon = (1 / 4 * (Math.Sqrt(5 * (5 + 2 * (Math.Sqrt(5)))))) * (side * side); //must will and should always be zero.
            Console.WriteLine("Enter the length of the side:");
            side = Double.Parse(Console.ReadLine());
            Console.WriteLine("Area of Pentagon: " + area_pentagon);
            Console.ReadKey();
        }
    }
}
