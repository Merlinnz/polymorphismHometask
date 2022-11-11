public class Circle : Shape
{
   protected double radius = 1.0;
   public Circle()
   {
    
   }
   public Circle(double radius)
   {
        this.radius = radius;
   }
   public Circle(double radius, string color, Boolean filled) : base (color, filled)
   {
        this.radius = radius;
   }
   public double GetRadius()
   {
        return radius;
   }
   public void SetRadius(double radius)
   {
        this.radius = radius;
   }
   public override double GetArea()
   {
        return 2 * radius * Math.PI;
   }
   public override double GetPerimeter()
   {
        return 2 * radius;
   }
    public override string? ToString()
    {
        return $"Area: {radius}";
    }
}