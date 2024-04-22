// Bad example violating LSP
public class Rectangle
{
    public int Width { get; set; }
    public int Height { get; set; }

    public virtual void SetWidth(int width)
    {
        Width = width;
    }

    public virtual void SetHeight(int height)
    {
        Height = height;
    }

    public int CalculateArea()
    {
        return Width * Height;
    }
}

public class Square : Rectangle
{
    public override void SetWidth(int width)
    {
        Width = width;
        Height = width;
    }

    public override void SetHeight(int height)
    {
        Width = height;
        Height = height;
    }
}

// Good example following LSP
public abstract class Shape
{
    public abstract int CalculateArea();
}

public class Rectangle : Shape
{
    public int Width { get; set; }
    public int Height { get; set; }

    public override int CalculateArea()
    {
        return Width * Height;
    }
}

public class Square : Shape
{
    public int SideLength { get; set; }

    public override int CalculateArea()
    {
        return SideLength * SideLength;
    }
}

//Rectangle rectangle = new Square();
//rectangle.SetWidth(5);
//rectangle.SetHeight(3);

//int area = rectangle.CalculateArea(); // Expected result: 15, Actual result: 9