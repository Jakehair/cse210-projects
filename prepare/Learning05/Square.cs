class Square : Shape
{
    private double side;

    public Square(string _color, double _side) : base(_color)
    {
        side = _side;

    }



    public override double GetArea()
    {
        return side * side;
    }
}