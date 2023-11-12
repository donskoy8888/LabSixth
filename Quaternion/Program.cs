using System;
class Program
{
    static void Main()
    {
        Quaternion quat1 = new Quaternion(1, 2, 3, 4);
        Quaternion quat2 = new Quaternion(5, 6, 7, 8);

        Quaternion sum = quat1 + quat2;
        Quaternion difference = quat1 - quat2;
        Quaternion product = quat1 * quat2;

        Console.WriteLine("Quaternion 1: " + quat1.ToString());
        Console.WriteLine("Quaternion 2: " + quat2.ToString());

        Console.WriteLine("Sum: " + sum.ToString());
        Console.WriteLine("Difference: " + difference.ToString());
        Console.WriteLine("Product: " + product.ToString());

        Console.WriteLine("Norm of Quaternion 1: " + quat1.Norm());
        Console.WriteLine("Conjugate of Quaternion 1: " + quat1.Conjugate().ToString());
        Console.WriteLine("Inverse of Quaternion 1: " + quat1.Inverse().ToString());

        double[,] rotationMatrix = quat1.ToRotationMatrix();
        Console.WriteLine("Rotation Matrix from Quaternion 1:");
        PrintMatrix(rotationMatrix);

        Console.WriteLine("Are Quaternion 1 and Quaternion 2 equal? " + (quat1 == quat2));
        Console.WriteLine("Are Quaternion 1 and the conjugate of Quaternion 1 equal? " + (quat1 == quat1.Conjugate()));

    }

    static void PrintMatrix(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
