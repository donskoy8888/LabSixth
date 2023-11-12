class GraphicsEditor
{
    private List<GraphicPrimitive> primitives = new List<GraphicPrimitive>();

    public void AddPrimitive()
    {
        primitives.Add(new Circle());
        primitives.Add(new Rectangle());
        primitives.Add(new Triangle());
    }

    public void ChangeScale(int scale)
    {
        foreach (var primitive in primitives)
        {
            primitive.Scale(scale);
        }
    }

    public void DrawFigure()
    {
        foreach (var primitive in primitives)
        {
            primitive.Draw();
        }
    }
}