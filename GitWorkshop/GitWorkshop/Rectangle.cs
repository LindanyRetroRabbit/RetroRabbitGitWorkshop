using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitWorkshop
{
    class Rectangle
    {
        int length;
        int width;

        public Rectangle() {
            this.length = 0;
            this.width = 0;
        }

        public void Area() {
            this.length = int.Parse(Console.ReadLine());
            this.width = int.Parse(Console.ReadLine());

            double area = this.length * this.width;
            Console.WriteLine("The area is: "+area);
        }

    }
}
