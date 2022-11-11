public class Rectangle : Shape
{
    protected double width = 1.0;
    public double height = 1.0;
    public Rectangle()
    {
        
    }
    public Rectangle(double width, double length)
    {
        this.width = width;
        this.height = length;
    }
    public Rectangle(double width, double length, string color, Boolean filled) : base(color, filled)
    {
        this.width = width;
        this.height = length;
    }
    public double GetWidth()
    {
        return width;
    }
    public void SetWidth(double width)
    {
        this.width = width;
    }
    public double GetLength()
    {
        return height;
    }
    public void SetLength(double length)
    {
        this.height = length;
    }
    public override double GetArea()
    {
        return width * height;
    }
    public override double GetPerimeter()
    {
        return 2 * (width + height);
    }
    public override string? ToString()
    {
        return base.ToString() + width + height;
    }
}