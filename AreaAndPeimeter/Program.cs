namespace AreaAndPeimeter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Area And Perimeter of Rectangle and Circle");
            Console.WriteLine("Area and perimeter finder");
            Console.WriteLine("Press 1 for");
            Console.WriteLine("Area and perimeter of reactangle");
            Console.WriteLine("Press 2 for");
            Console.WriteLine("Area and perimeter of circle");
            
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    Console.WriteLine("Enter length");
                    int length = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter breadth");
                    int breadth = Convert.ToInt32(Console.ReadLine());
                    AreaPerimeter reactangle = new AreaPerimeter();
                    reactangle.AreaAndPerimeterOfRectangle(length, breadth);
                    break;
                case 2:
                    Console.WriteLine("Enter Radius");
                    int radius = Convert.ToInt32(Console.ReadLine());
                    AreaPerimeter circle = new AreaPerimeter();
                    circle.AreaAndPerimeterOfCircle(radius);
                    break;
                default:
                    Console.WriteLine("Wrong Choise");
                    break;
            }
        }
    }
    
}