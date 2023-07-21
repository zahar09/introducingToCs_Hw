/*Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/
Console.Write("Введите размер массива (n*n) n: ");
int n = int.Parse(Console.ReadLine());
int count = 1;
int[,] array = GetArray(n,n);
FillArray(array);
PrintArray(array);

/* 
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07


*/


int[,] GetArray(int n,int m)
{
    int[,] array = new int[n,m];
    return array;
}
void FillArray(int[,] arr){
    int length = arr.GetLength(0);
    for(int i = 0;i < length;i++){
        for(int j = i;j < length-i;j++){
            arr[i,j] = count;
            count++;
        }
        for(int j = i+1;j < length - i;j++){
            arr[j,length-i-1] = count;
            count++;
        }
        for(int j = length - 2- i;j >= i;j--){
            arr[length-1-i,j] = count;
            count++;
        }
        for(int j = length - 2 - i;j > i;j--){
            arr[j,i] = count;
            count++;
        }
    }
    
}
        // for (int j = 0; j < array.GetLength(1) - 1 - i; j++)
        // {
        //     array[i,j] = count;
        //     count++;
        // }
        // for (int j = 0; j < array.GetLength(1) - 2 - i; j++)
        // {
        //     array[j,array.GetLength(1)-1-i] = count;
        //     count++;
        // }
        // for (int j = array.GetLength(1) - 2 - i; j >= 0 ; j--)
        // {
        //     array[j,array.GetLength(1)-1-i] = count;
        //     count++;
        // }
        // for (int j = array.GetLength(1)- 3 - i; j >= 0; j--)
        // {
        //     array[j,i] = count;
        //     count++;
        // }
    
    


void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write(inArray[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}



