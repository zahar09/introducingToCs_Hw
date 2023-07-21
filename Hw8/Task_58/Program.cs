// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


// 6+12 = 18
// 8+12 = 20
// 9+6 = 15
// 12+6 = 18

Console.Write("Введите количество строк в первом массиве: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов в первом массиве: ");
int n = int.Parse(Console.ReadLine());

Console.Write("Введите максимальное число в первом массиве: ");
int max = int.Parse(Console.ReadLine());

Console.Write("Введите минимальное число в первом массиве: ");
int min = int.Parse(Console.ReadLine());

Console.Write("Введите количество строк во втором массиве: ");
int m2 = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов во втором массиве: ");
int n2 = int.Parse(Console.ReadLine());

Console.Write("Введите максимальное число во втором массиве: ");
int max2 = int.Parse(Console.ReadLine());

Console.Write("Введите минимальное число во втором массиве: ");
int min2 = int.Parse(Console.ReadLine());


int[,] array = GetArray(m,n,min,max);
int[,] array2 = GetArray(m2,n2,min2,max2);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
PrintArray(array2);
Console.WriteLine();

int[,] arr3 = MatrixMultiplication(array,array2);





int[,] GetArray(int m,int n,int min,int max){
    int[,] array = new int[m,n];

    for(int i = 0;i < m;i++){
        for(int j = 0;j < n;j++){
            array[i,j] = new Random().Next(min,max + 1);
        }
    }
    return array;
}



void PrintArray(int[,] arr){
    for(int i = 0;i < arr.GetLength(0);i++){
        for(int j = 0;j < arr.GetLength(1);j++){
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
}

int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
    {       
        if (matrixA.GetLength(1) != matrixB.GetLength(0))
        {
            throw new Exception("Умножение не возможно! "+
                "Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
        }

        int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

        for (int i = 0; i < matrixA.GetLength(0); i++)
        {
            for (int j = 0; j < matrixB.GetLength(1); j++)
            {

                for (int k = 0; k < matrixA.GetLength(1); k++)
                {
                    matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }

        return matrixC;
    }


