using System;

public class TestParabola
{
    public static bool IsOnTheGraph(Parabola parabola, Point p)
    {
        return parabola.IsOnTheGraph(p);
    }

    public static Point GetMinMax(Parabola parabola)
    {
        return parabola.GetMinMax();
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter coefficient a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter coefficient b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter coefficient c: ");
        double c = double.Parse(Console.ReadLine());

        Parabola p1 = new Parabola(a, b, c);
        Console.WriteLine($"Parabola created: {p1}");

        double[] roots = p1.getRoots();
        if (roots.Length == 0)
        {
            Console.WriteLine("The parabola has no real roots.");
        }
        else if (roots.Length == 1)
        {
            Console.WriteLine($"The parabola has one root: x = {roots[0]}");
        }
        else
        {
            Console.WriteLine($"The parabola has two roots: x1 = {roots[0]}, x2 = {roots[1]}");
        }

        Console.WriteLine("\nEnter coefficients for the first parabola (a, b, c):");
        Parabola par1 = new Parabola(
            double.Parse(Console.ReadLine()),
            double.Parse(Console.ReadLine()),
            double.Parse(Console.ReadLine())
        );

        Console.WriteLine("Enter coefficients for the second parabola (a, b, c):");
        Parabola par2 = new Parabola(
            double.Parse(Console.ReadLine()),
            double.Parse(Console.ReadLine()),
            double.Parse(Console.ReadLine())
        );

        Console.WriteLine("\nParabola 1: " + par1);
        Console.WriteLine("Vertex 1: " + par1.GetMinMax());

        Console.WriteLine("Parabola 2: " + par2);
        Console.WriteLine("Vertex 2: " + par2.GetMinMax());

        Point[] intersectionPoints = par1.GetCuttingPoint(par2);
        Console.WriteLine($"Number of intersection points: {intersectionPoints.Length}");
        for (int i = 0; i < intersectionPoints.Length; i++)
        {
            Console.WriteLine($"Intersection point {i + 1}: {intersectionPoints[i]}");
        }
    }
}
