using System;

public class Parabola
{
    private double a;
    private double b;
    private double c;

 
    public Parabola(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    // חישוב ערך ה-y עבור x נתון
    public double calculateY(double x)
    {
        return this.a * x * x + this.b * x + this.c;
    }

   
    public double[] getRoots()
    {
        double delta = this.b * this.b - 4 * this.a * this.c;

        if (delta < 0)
        {
            return new double[0]; 
        }
        else if (delta == 0)
        {
            double root = -this.b / (2 * this.a);
            return new double[] { root };
        }
        else
        {
            double root1 = (-this.b + Math.Sqrt(delta)) / (2 * this.a);
            double root2 = (-this.b - Math.Sqrt(delta)) / (2 * this.a);
            return new double[] { root1, root2 }; 
        }
    }

    
    public override string ToString()
    {
        return $"y = {this.a}x^2 + {this.b}x + {this.c}";
    }

    // 
    public bool IsOnTheGraph(Point p)
    {
        double expectedY = calculateY(p.GetX());
        return Math.Abs(expectedY - p.GetY()) < 0.0001; 
    }

   
    public Point GetMinMax()
    {
        double xVertex = -this.b / (2 * this.a);
        double yVertex = calculateY(xVertex);
        return new Point(xVertex, yVertex);
    }

    
    public Point[] GetCuttingPoint(Parabola other)
    {
        
        double diffA = this.a - other.a;
        double diffB = this.b - other.b;
        double diffC = this.c - other.c;

        if (diffA == 0)
        {
            if (diffB == 0)
            {
                return new Point[0]; 
            }
            double x = -diffC / diffB;
            double y = calculateY(x);
            return new Point[] { new Point(x, y) };
        }

        double delta = diffB * diffB - 4 * diffA * diffC;

        if (delta < 0)
        {
            return new Point[0];
        }
        else if (delta == 0)
        {
            double x = -diffB / (2 * diffA);
            double y = calculateY(x);
            return new Point[] { new Point(x, y) };
        }
        else
        {
            double x1 = (-diffB + Math.Sqrt(delta)) / (2 * diffA);
            double y1 = calculateY(x1);

            double x2 = (-diffB - Math.Sqrt(delta)) / (2 * diffA);
            double y2 = calculateY(x2);

            return new Point[] { new Point(x1, y1), new Point(x2, y2) };
        }
    }
}