class Triangle : Shape, IShape
{
    public Triangle()
    {
     
    }

    public Triangle(int hypo)
    {
        Hypoteneus = hypo;
    }

    public Triangle (int hypo, int height, int lengt)
    {
        Hypoteneus = hypo;
        Height = height;
        Length = lengt;
    }

    public double Hypoteneus { get; set; }

    public double getArea()
    {
        return .5 * Length * Height;
    }
}