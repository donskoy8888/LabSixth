using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(MathOperations.Add(5, 10));
        Console.WriteLine(MathOperations.Add(3.5, 2.7));

        int[] arr1 = { 1, 2, 3 };
        int[] arr2 = { 4, 5, 6 };
        int[] resultArray = MathOperations.Add(arr1, arr2);
        Console.WriteLine(string.Join(", ", resultArray));

        int[,] matrix1 = { { 1, 2 }, { 3, 4 } };
        int[,] matrix2 = { { 5, 6 }, { 7, 8 } };
        int[,] resultMatrix = MathOperations.Add(matrix1, matrix2);
        Console.WriteLine("Matrix Addition:");
        PrintMatrix(resultMatrix);

        int[,] resultSubtract = MathOperations.Subtract(matrix1, matrix2);
        Console.WriteLine("\nMatrix Subtraction:");
        PrintMatrix(resultSubtract);

        int[,] resultMultiply = MathOperations.Multiply(matrix1, matrix2);
        Console.WriteLine("\nMatrix Multiplication:");
        PrintMatrix(resultMultiply);

        int[,] resultDivide = MathOperations.Divide(matrix1, 2);
        Console.WriteLine("\nMatrix Division:");
        PrintMatrix(resultDivide);

        int[,,] tensor1 = { { { 1, 2 }, { 3, 4 } }, { { 5, 6 }, { 7, 8 } } };
        int[,,] tensor2 = { { { 9, 10 }, { 11, 12 } }, { { 13, 14 }, { 15, 16 } } };
        int[,,] resultTensorAdd = MathOperations.Add(tensor1, tensor2);
        Console.WriteLine("\nTensor Addition:");
        PrintTensor(resultTensorAdd);

        int[,,] resultTensorSubtract = MathOperations.Subtract(tensor1, tensor2);
        Console.WriteLine("\nTensor Subtraction:");
        PrintTensor(resultTensorSubtract);

        int[,,] resultTensorMultiply = MathOperations.Multiply(tensor1, tensor2);
        Console.WriteLine("\nTensor Multiplication:");
        PrintTensor(resultTensorMultiply);

        int[,,] resultTensorDivide = MathOperations.Divide(tensor1, 2);
        Console.WriteLine("\nTensor Division:");
        PrintTensor(resultTensorDivide);
    }

    static void PrintMatrix(int[,] matrix)
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

    static void PrintTensor(int[,,] tensor)
    {
        int dim1 = tensor.GetLength(0);
        int dim2 = tensor.GetLength(1);
        int dim3 = tensor.GetLength(2);

        for (int i = 0; i < dim1; i++)
        {
            for (int j = 0; j < dim2; j++)
            {
                for (int k = 0; k < dim3; k++)
                {
                    Console.Write(tensor[i, j, k] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
