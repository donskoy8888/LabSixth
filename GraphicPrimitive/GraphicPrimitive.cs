abstract class GraphicPrimitive
{
    private int x;
    private int y;

    public int X
    {
        get { return x; }
        set { x = value; }
    }

    public int Y
    {
        get { return y; }
        set { y = value; }
    }

    public abstract void Draw();

    public abstract void Move(int x, int y);

    public abstract void Scale(float factor);
    public abstract void Scale(float factor, float factorSecond);
}
