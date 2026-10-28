using System;

public class Point
{
    private double x;
    private double y;

   
    public Point(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

   
    public double GetX()
    {
        return this.x;
    }

    public void SetX(double x)
    {
        this.x = x;
    }

    public double GetY()
    {
        return this.y;
    }

    public void SetY(double y)
    {
        this.y = y;
    }

    
    public override string ToString()
    {
        return $"({this.x} , {this.y})";
    }
}