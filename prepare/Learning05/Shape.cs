abstract class Shape
{
    private string color;

    public string GetColor()
    {
        return color;
    }

    public void SetColor(string _color)
    {
        color = _color;
    }

    public Shape(string _color)
    {
        color = _color;
    }

    public abstract double GetArea();
}