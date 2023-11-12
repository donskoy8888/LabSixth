class Triangle : GraphicPrimitive
{
    private float height;

    public float Height
    {
        get { return height; }
        set { height = value; }
    }

    public override void Draw()
    {
        Console.WriteLine("Drawing Triangle:");
        for (int i = 1; i <= Height; i++)
        {
            for (int j = 1; j <= Height - i; j++)
            {
                Console.Write(" ");
            }
            for (int k = 1; k <= i; k++)
            {
                Console.Write('*');
            }
            for (int l = i - 1; l >= 1; l--)
            {
                Console.Write('*');
            }
            Console.Write("\n");
        }
    }

    public override void Scale(float factor)
    {
        Height = factor;
    }

    public override void Scale(float factor, float f) { }

    public override void Move(int y, int x)
    {
        Y += y;
        X += x;
    }
}