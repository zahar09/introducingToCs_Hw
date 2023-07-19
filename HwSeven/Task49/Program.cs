Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());

Console.Write("Введите максимальное число в массиве: ");
int max = int.Parse(Console.ReadLine());

Console.Write("Введите минимальное число в массиве: ");
int min = int.Parse(Console.ReadLine());

Console.Write("Введите индекс элемента (строка): ");
int r = int.Parse(Console.ReadLine());

Console.Write("Введите индекс элемента (колонка): ");
int c = int.Parse(Console.ReadLine());

int[,] array = GetArray(m,n,min,max);
PrintArray(array);
Console.WriteLine();

int ans = Find(array,r,c);
if(ans == 0){
    Console.WriteLine("Такого элемента нет");
}
else{
    Console.WriteLine(ans);
}

int[,] GetArray(int m,int n,int min,int max){
    int[,] array = new int[m,n];

    for(int i = 0;i < m;i++){
        for(int j = 0;j < n;j++){
            array[i,j] = new Random().Next(min,max + 1);
        }
    }
    return array;
}

int Find(int[,] array,int r,int c){
    //bool isFind = false;
    if(r < array.GetLength(0) && c < array.GetLength(1)){
        return array[r,c];
    }
    else{
        return 0;
    }
    
   
}

void PrintArray(int[,] arr){
    for(int i = 0;i < arr.GetLength(0);i++){
        for(int j = 0;j < arr.GetLength(1);j++){
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
}
