using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaAndPeimeter
{
    internal class AreaPerimeter
    {
        internal void AreaAndPerimeterOfRectangle(int length, int breadth)
        {
            int area;
            int perimeter;
            area = length * breadth;
            perimeter = 2 * (length + breadth);
            Console.WriteLine("Area and perimeter of rectangle with length: {0} and breadth: {1} is {2} and {3} respectively ", length, breadth, area, perimeter);
        }

        internal void AreaAndPerimeterOfCircle(int radius)
        {

            const float pi = 3.1416f;
            float perimeter = 2 * pi * radius;
            float area = pi * radius * radius;
          
            Console.WriteLine("Area and perimeter of cirvle with radius: {0} is {1} and {2} respectively ", radius, area, perimeter);

        }
    }
}
