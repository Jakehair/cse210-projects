class Rectangle : Shape
{
    double length;
    double width;

    public Rectangle(string _color, double _length, double _width) : base(_color)
    {
        length = _length;
        width = _width;
    }

    public override double GetArea()
    {
        return length * width;
    }

}