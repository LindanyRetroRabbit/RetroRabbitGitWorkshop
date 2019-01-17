using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitWorkshop
{
    class Triangle
    {
        double h;
        double b;

        public Triangle()
        {
            this.h = 0;
            this.b = 0;
        }

        public Triangle(double height, double breadth)
        {
            this.h = height;
            this.b = breadth;
        }

        public void Area_of_Triangle(double height, double breadth)
        {
            Console.WriteLine("Enter the height");
            double he = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the breadth");
            double be = double.Parse(Console.ReadLine());
            double area = 0.5 * he * be;
            Console.WriteLine("The area of the Triangle is: "+area);
        }
    }
}
