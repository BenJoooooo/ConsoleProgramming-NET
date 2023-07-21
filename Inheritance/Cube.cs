class Cube : Shape, IShape
{
    public Cube(int width, int length, int height)
    {
        Width = width; 
        Height = height;
        Length = length;
    }

    public double Width { get; set; }

    public double getArea()
    { 
        return Length * Width;
    }

    public double getVolume()
    {
        return Length * Width * Height;
    }
}