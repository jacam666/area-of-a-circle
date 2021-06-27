using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area_of_a_circle
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14;
            double radius;
            Console.WriteLine("Please input your radius :");
            radius = Convert.ToDouble(Console.ReadLine());
            double area;
            area = (pi * radius * radius);
            Console.WriteLine("The area of your circle is :");
            Console.WriteLine(area);
        }
    }
}
