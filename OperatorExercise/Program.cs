namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int c = 5;
            int d = 10;

            int addition = c + d;
            int subtraction = c - d;
            int multiplication = c * d;
            int division = c / d;
            int modulus = c % d;
           
                
           
            int a = 17;
            int b = 4;

            int quotient = a / b;
            int remainder = a % b;


            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");

            Console.WriteLine("What is the radius of the circle");
            double radius = double.Parse(Console.ReadLine());
            double area = AreaOfCircle(radius);
            Console.WriteLine($"The area of the circle with the radius of {radius} is: " + area);
            Console.ReadLine();
            static double AreaOfCircle(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }
        // Thought Exercise : K = 16

        }
    }
}
