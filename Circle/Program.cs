namespace Circle
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter radius of Circle: ");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"Your radius you enter is: {radius}");
            double area = Math.PI * radius * radius;
            double circum = 2 * Math.PI * radius;
            area = Math.Round(area, 2);
            circum = Math.Round(circum, 2); 
            Console.WriteLine($"Area of circle is : {area}");
            Console.WriteLine($"Circumference {circum}");
        }
    }
}
