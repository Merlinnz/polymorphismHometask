public class Square : Rectangle
{
    public Square()
    {
        
    }
    public Square(double side)
    {
        width = side;
    }
    public Square(double side, string color, Boolean filled)
    {
        width = side;        
    }
    public double GetSide()
    {
        return width;
    }
    public void SetSide(double side)
    {
        width = side;
    }
   /* public override void SetWidth(double side)
    {
        width = side;
    }
    public override void SetLenght(double side)
    {
        length = side;
    } */
    public override string ToString()
    {
        return base.ToString() + " " + width;
    }

}