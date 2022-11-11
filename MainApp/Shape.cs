public abstract class Shape
{
    protected string? color;
    protected Boolean  filled = true;
    public Shape()
    {
        
    }
    public Shape(string color, Boolean filled)
    {
        this.color = color;
        this.filled = filled;
    }
    public string? GetColor()
    {
        return this.color;
    }
    public void SetColor(string color)
    {
        this.color = color;
    }
    public Boolean IsFilled()
    {
        return this.filled;
    }
    public void SetFilled(Boolean filled)
    {
        this.filled = filled;
    }
    public abstract double GetArea();
    public abstract double GetPerimeter();
    
    public override string? ToString()
    {
        return base.ToString();
    }

}