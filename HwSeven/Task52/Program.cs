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
float[] average = GetAverage(array);
PrintArray2(average);

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
void PrintArray2(float[] arr){
    Console.Write($"{arr[0]}");
    for(int i = 1;i < arr.Length;i++){
        Console.Write($", {arr[i]}");
    }
}


float[] GetAverage(int[,] arr){
    float[] average = new float[n];
    for(int i = 0; i < n; i++){
        for(int j = 0;j < m;j++){
            average[i] += arr[j,i];
        }
        average[i] /= n;
    }
    return average;
}
