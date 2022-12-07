namespace ConsoleApp1;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter the radius: ");
        double radius = double.Parse(Console.ReadLine());
        var area = AreaOfCircle(radius);
        Console.WriteLine($"The area of the circle is: {area}");
    }

    public static double AreaOfCircle(double radius)
    {
        return Math.PI * Math.Pow(radius, 2);
    }
}








