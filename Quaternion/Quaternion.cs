public class Quaternion
{
    private double w;
    private double x;
    private double y;
    private double z;

    public double W
    {
        get { return w; }
        set { w = value; }
    }
    public double X
    {
        get { return x; }
        set { x = value; }
    }
    public double Y
    {
        get { return y; }
        set { y = value; }
    }
    public double Z
    {
        get { return z; }
        set { z = value; }
    }

    public Quaternion(double w, double x, double y, double z)
    {
        W = w;
        X = x;
        Y = y;
        Z = z;
    }

    public static Quaternion operator +(Quaternion a, Quaternion b)
    {
        return new Quaternion(a.W + b.W, a.X + b.X, a.Y + b.Y, a.Z + b.Z);
    }

    public static Quaternion operator -(Quaternion a, Quaternion b)
    {
        return new Quaternion(a.W - b.W, a.X - b.X, a.Y - b.Y, a.Z - b.Z);
    }

    public static Quaternion operator *(Quaternion a, Quaternion b)
    {
        double w = a.W * b.W - a.X * b.X - a.Y * b.Y - a.Z * b.Z;
        double x = a.W * b.X + a.X * b.W + a.Y * b.Z - a.Z * b.Y;
        double y = a.W * b.Y - a.X * b.Z + a.Y * b.W + a.Z * b.X;
        double z = a.W * b.Z + a.X * b.Y - a.Y * b.X + a.Z * b.W;

        return new Quaternion(w, x, y, z);
    }


    public double Norm()
    {
        return Math.Sqrt(W * W + X * X + Y * Y + Z * Z);
    }

    public Quaternion Conjugate()
    {
        return new Quaternion(W, -X, -Y, -Z);
    }

    public Quaternion Inverse()
    {
        double normSquared = W * W + X * X + Y * Y + Z * Z;
        double factor = 1 / normSquared;

        return new Quaternion(W * factor, -X * factor, -Y * factor, -Z * factor);
    }

    public static bool operator ==(Quaternion a, Quaternion b)
    {
        return a.W == b.W && a.X == b.X && a.Y == b.Y && a.Z == b.Z;
    }

    public static bool operator !=(Quaternion a, Quaternion b)
    {
        return !(a == b);
    }


    public double[,] ToRotationMatrix()
    {
        double[,] matrix = new double[3, 3];

        double w2 = W * W;
        double x2 = X * X;
        double y2 = Y * Y;
        double z2 = Z * Z;

        double wx = W * X;
        double wy = W * Y;
        double wz = W * Z;

        double xy = X * Y;
        double xz = X * Z;

        double yz = Y * Z;

        matrix[0, 0] = w2 + x2 - y2 - z2;
        matrix[1, 1] = w2 - x2 + y2 - z2;
        matrix[2, 2] = w2 - x2 - y2 + z2;

        matrix[0, 1] = 2 * (xy - wz);
        matrix[1, 0] = 2 * (xy + wz);

        matrix[0, 2] = 2 * (xz + wy);
        matrix[2, 0] = 2 * (xz - wy);

        matrix[1, 2] = 2 * (yz - wx);
        matrix[2, 1] = 2 * (yz + wx);

        return matrix;
    }

    public override string ToString()
    {
        return $"({W}, {X}, {Y}, {Z})";
    }

    public override bool Equals(object obj)
    {
        if (ReferenceEquals(this, obj))
        {
            return true;
        }

        if (ReferenceEquals(obj, null))
        {
            return false;
        }

        throw new NotImplementedException();
    }
}