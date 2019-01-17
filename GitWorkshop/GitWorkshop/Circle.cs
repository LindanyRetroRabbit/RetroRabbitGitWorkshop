using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitWorkshop
{
    class Circle
    {
        void areaC()
        {
            Console.WriteLine("Enter side length");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Area is"+3.14 * r * r);
        }
    }
}
