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
Console.WriteLine();
int ans = FindAns(array);
Console.WriteLine(ans);



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

int FindAns(int[,] arr){
    int sumMin = 0;
    int sumNow = 0;
    int index = 0;
    for(int i = 0;i < arr.GetLength(0);i++){
        for(int j = 0;j < arr.GetLength(1);j++){
            sumNow+=array[i,j];
        }
        if(i == 0){
            sumMin = sumNow;
        }
        else if(sumNow < sumMin){
            sumMin = sumNow;
            index = i;
        }
        sumNow = 0;
        
    }
    return index+1;
}
