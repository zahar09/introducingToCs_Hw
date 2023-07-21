// Задайте двумерный массив. Напишите программу, которая упорядочит 
//по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());

Console.Write("Введите максимальное число в массиве: ");
int max = int.Parse(Console.ReadLine());

Console.Write("Введите минимальное число в массиве: ");
int min = int.Parse(Console.ReadLine());

int[,] array = GetArray(m,n,min,max);
Console.WriteLine();
PrintArray(array);
ChangeArray(array);
Console.WriteLine();
PrintArray(array);



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

void ChangeArray(int[,] arr){
    for(int i = 0;i < arr.GetLength(0);i++){
        for(int k = 0;k < arr.GetLength(1);k++){
            for(int j = 0;j < arr.GetLength(1)-1;j++){
                if(arr[i,j] < arr[i,j+1]){
                    int help = arr[i,j];
                    arr[i,j] = arr[i,j+1];
                    arr[i,j+1] = help;
                }
            }
        }

        
    }
}
