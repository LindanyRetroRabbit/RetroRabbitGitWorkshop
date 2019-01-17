using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitWorkshop
{
    class Square
    {

        public void Area()
        {
            Console.Write("Enter square length : ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Area is : " + (n * n));
            Console.ReadKey();

        }

    }
}
