class Circle : GraphicPrimitive
{
    private float radius;

    public float Radius
    {
        get { return radius; }
        set { radius = value; }
    }

    public override void Draw()
    {
        Console.WriteLine("Drawing Circle:");
        int centerX = (int)Math.Round(Radius);
        int centerY = (int)Math.Round(Radius);

        for (int i = 0; i <= 2 * Radius; i++)
        {
            for (int j = 0; j <= 2 * Radius; j++)
            {
                float dx = centerX - j;
                float dy = centerY - i;

                if (dx * dx + dy * dy <= Radius * Radius)
                {
                    Console.Write('*');
                }
                else
                {
                    Console.Write(' ');
                }
            }
            Console.WriteLine();
        }
    }

    public override void Scale(float factor)
    {
        Radius = factor;
    }

    public override void Scale(float factor, float f) { }

    public override void Move(int y, int x)
    {
        Y += y;
        X += x;
    }
}