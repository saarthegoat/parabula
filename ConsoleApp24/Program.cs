
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
        // 
       
        Console.Write("put a : ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("put b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("put c: ");
        double c = double.Parse(Console.ReadLine());

        Parabola p1 = new Parabola(a, b, c);
        Console.WriteLine($"the new parabula: {p1}");

        double[] roots = p1.getRoots();
        if (roots.Length == 0)
        {
            Console.WriteLine("לפרבולה אין שורשים ממשיים.");
        }
        else if (roots.Length == 1)
        {
            Console.WriteLine($"לפרבולה שורש יחיד: x = {roots[0]}");
        }
        else
        {
            Console.WriteLine($"לפרבולה שני שורשים: x1 = {roots[0]}, x2 = {roots[1]}");
        }

        // ט. חקירת שתי פרבולות
        Console.WriteLine("\n--- סעיף ט' ---");
        Console.WriteLine("הכנס מקדמים לפרבולה הראשונה (a, b, c בהפרדה של אנטר):");
        Parabola par1 = new Parabola(
            double.Parse(Console.ReadLine()),
            double.Parse(Console.ReadLine()),
            double.Parse(Console.ReadLine())
        );

        Console.WriteLine("הכנס מקדמים לפרבולה השנייה (a, b, c בהפרדה של אנטר):");
        Parabola par2 = new Parabola(
            double.Parse(Console.ReadLine()),
            double.Parse(Console.ReadLine()),
            double.Parse(Console.ReadLine())
        );

        Console.WriteLine("\n--- תוצאות החקירה ---");
        Console.WriteLine($"parabula num 1: {par1}");
        Console.WriteLine($"kodkod parabula num 1: {par1.GetMinMax()}");

        Console.WriteLine($"parabula num 2: {par2}");
        Console.WriteLine($"kodkod parabula num 2: {par2.GetMinMax()}");

        Point[] intersectionPoints = par1.GetCuttingPoint(par2);
        Console.WriteLine($"num of cutting point: {intersectionPoints.Length}");
        for (int i = 0; i < intersectionPoints.Length; i++)
        {
            Console.WriteLine($"cutting point {i + 1}: {intersectionPoints[i]}");
        }
    }
}