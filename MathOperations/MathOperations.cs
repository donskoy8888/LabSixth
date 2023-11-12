class MathOperations
{
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static double Add(double a, double b)
    {
        return a + b;
    }

    public static int[] Add(int[] arr1, int[] arr2)
    {
        if (arr1.Length != arr2.Length)
            throw new ArgumentException("Array lengths must be equal.");

        int[] result = new int[arr1.Length];
        for (int i = 0; i < arr1.Length; i++)
        {
            result[i] = arr1[i] + arr2[i];
        }

        return result;
    }

    public static int[,] Add(int[,] matrix1, int[,] matrix2)
    {
        if (matrix1.GetLength(0) != matrix2.GetLength(0) || matrix1.GetLength(1) != matrix2.GetLength(1))
            throw new ArgumentException("Matrix dimensions must be equal.");

        int rows = matrix1.GetLength(0);
        int cols = matrix1.GetLength(1);

        int[,] result = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }

        return result;
    }

    public static int[,,] Add(int[,,] tensor1, int[,,] tensor2)
    {
        int dim1 = tensor1.GetLength(0);
        int dim2 = tensor1.GetLength(1);
        int dim3 = tensor1.GetLength(2);

        if (dim1 != tensor2.GetLength(0) || dim2 != tensor2.GetLength(1) || dim3 != tensor2.GetLength(2))
            throw new ArgumentException("Tensor dimensions must be equal.");

        int[,,] result = new int[dim1, dim2, dim3];
        for (int i = 0; i < dim1; i++)
        {
            for (int j = 0; j < dim2; j++)
            {
                for (int k = 0; k < dim3; k++)
                {
                    result[i, j, k] = tensor1[i, j, k] + tensor2[i, j, k];
                }
            }
        }

        return result;
    }

    public static int Subtract(int a, int b)
    {
        return a - b;
    }

    public static int[,] Subtract(int[,] matrix1, int[,] matrix2)
    {
        if (matrix1.GetLength(0) != matrix2.GetLength(0) || matrix1.GetLength(1) != matrix2.GetLength(1))
            throw new ArgumentException("Matrix dimensions must be equal.");

        int rows = matrix1.GetLength(0);
        int cols = matrix1.GetLength(1);

        int[,] result = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = matrix1[i, j] - matrix2[i, j];
            }
        }

        return result;
    }

    public static int[,,] Subtract(int[,,] tensor1, int[,,] tensor2)
    {
        int dim1 = tensor1.GetLength(0);
        int dim2 = tensor1.GetLength(1);
        int dim3 = tensor1.GetLength(2);

        if (dim1 != tensor2.GetLength(0) || dim2 != tensor2.GetLength(1) || dim3 != tensor2.GetLength(2))
            throw new ArgumentException("Tensor dimensions must be equal.");

        int[,,] result = new int[dim1, dim2, dim3];
        for (int i = 0; i < dim1; i++)
        {
            for (int j = 0; j < dim2; j++)
            {
                for (int k = 0; k < dim3; k++)
                {
                    result[i, j, k] = tensor1[i, j, k] - tensor2[i, j, k];
                }
            }
        }

        return result;
    }

    public static int Multiply(int a, int b)
    {
        return a * b;
    }

    public static int[,] Multiply(int[,] matrix1, int[,] matrix2)
    {
        if (matrix1.GetLength(1) != matrix2.GetLength(0))
            throw new ArgumentException("Number of columns in the first matrix must be equal to the number of rows in the second matrix.");

        int rows = matrix1.GetLength(0);
        int cols = matrix2.GetLength(1);
        int common = matrix1.GetLength(1);

        int[,] result = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                for (int k = 0; k < common; k++)
                {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }

        return result;
    }

    public static int[,,] Multiply(int[,,] tensor1, int[,,] tensor2)
    {
        int dim1 = tensor1.GetLength(0);
        int dim2 = tensor1.GetLength(1);
        int dim3 = tensor1.GetLength(2);

        if (dim1 != tensor2.GetLength(0) || dim2 != tensor2.GetLength(1) || dim3 != tensor2.GetLength(2))
            throw new ArgumentException("Tensor dimensions must be equal.");

        int[,,] result = new int[dim1, dim2, dim3];
        for (int i = 0; i < dim1; i++)
        {
            for (int j = 0; j < dim2; j++)
            {
                for (int k = 0; k < dim3; k++)
                {
                    result[i, j, k] = tensor1[i, j, k] * tensor2[i, j, k];
                }
            }
        }

        return result;
    }

    public static double Divide(int a, int b)
    {
        if (b == 0)
            throw new DivideByZeroException("Cannot divide by zero.");

        return (double)a / b;
    }

    public static int[,] Divide(int[,] matrix, int divisor)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        int[,] result = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = matrix[i, j] / divisor;
            }
        }

        return result;
    }

    public static int[,,] Divide(int[,,] tensor, int divisor)
    {
        int dim1 = tensor.GetLength(0);
        int dim2 = tensor.GetLength(1);
        int dim3 = tensor.GetLength(2);

        int[,,] result = new int[dim1, dim2, dim3];
        for (int i = 0; i < dim1; i++)
        {
            for (int j = 0; j < dim2; j++)
            {
                for (int k = 0; k < dim3; k++)
                {
                    result[i, j, k] = tensor[i, j, k] / divisor;
                }
            }
        }

        return result;
    }
}