using System;
using System.Diagnostics;

public class MatrixCalculations
{
	public MatrixCalculations()
	{

	}

    internal int[,] MultiplyMatrices(int[,] firstMatrix, int[,] secondMatrix)
    {
        // Obtaining the dimensions of the matrices
       int x1 = firstMatrix.GetLength(0);
       int y1 = firstMatrix.GetLength(1);
       int x2 = secondMatrix.GetLength(0);
       int y2 = secondMatrix.GetLength(1);
        //Initializing the result matrix
       int[,] ResultMatrix = new int[x1, y2];

        // Checking if the matrices can be multiplied
        if (y1 != x2)
        {
            throw new Exception("The matrices cannot be multiplied");
        }
        // MultiThreading using Thread 
        var Stopwatch = new Stopwatch();
        Stopwatch.Start();
                Thread[] threads = new Thread[x1];

        for (int i = 0; i < x1; i++)
        {
            for (int j = 0; j < y2; j++)
            {
                int x = i;
                int y = j;
                threads[j] = new Thread(() =>
                {
                    
                    ResultMatrix[x, y] = Multiplication(firstMatrix, secondMatrix, x, y);
                });
                threads[j].Start();
            }
            for (int j = 0; j < y2; j++)
            {
                threads[j].Join();
            }
        }
        Stopwatch.Stop();
        TimeSpan time1 = Stopwatch.Elapsed;
        Stopwatch.Reset();
      
       

        return ResultMatrix;
    }
    private int Multiplication(int[,] firstMatrix, int[,] secondMatrix,int x, int y)
    {
        int result = 0;
        for (int i = 0; i < firstMatrix.GetLength(1); i++)
        {
            result += firstMatrix[x, i] * secondMatrix[i,y];
        }
        return result;
        
    }
}
