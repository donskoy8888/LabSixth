class Rectangle : GraphicPrimitive
{
    private float width;
    private float height;

    public float Width
    {
        get { return width; }
        set { width = value; }
    }

    public float Height
    {
        get { return height; }
        set { height = value; }
    }

    public override void Draw()
    {
        Console.WriteLine("Drawing Rectangle:");
        for (int i = 0; i < Height; i++)
        {
            for (int j = 0; j < Width; j++)
            {
                Console.Write('*');
            }
            Console.WriteLine();
        }
    }

    public override void Scale(float factor)
    {
        Width = factor;
        Height = factor;
    }

    public override void Scale(float factor, float factorSecond)
    {
        Width *= factor;
        Height *= factorSecond;
    }

    public override void Move(int y, int x)
    {
        Y += y;
        X += x;
    }
}