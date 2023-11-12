class Group : GraphicPrimitive
{
    private List<GraphicPrimitive> groupPrimitives = new List<GraphicPrimitive>();

    public void AddPrimitive()
    {
        groupPrimitives.Add(new Circle());
        groupPrimitives.Add(new Rectangle());
        groupPrimitives.Add(new Triangle());
    }

    public override void Draw()
    {
        Console.WriteLine("Drawing Group:");
        foreach (var primitive in groupPrimitives)
        {
            primitive.Draw();
        }
    }

    public override void Move(int x, int y)
    {
        foreach (var primitive in groupPrimitives)
        {
            primitive.Move(x, y);
        }
    }

    public override void Scale(float factor)
    {
        foreach (var primitive in groupPrimitives)
        {
            primitive.Scale(factor);
        }
    }

    public override void Scale(float factor, float factorSecond)
    {
        foreach (var primitive in groupPrimitives)
        {
            primitive.Scale(factor, factorSecond);
        }
    }
}