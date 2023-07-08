//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int sizeOfArr = 8;
int[] array = GetArr(sizeOfArr);
PrintArr(array);

int[] GetArr(int size){
    int[] arr = new int[size];
    for(int i = 0;i < size;i++){
        arr[i] = new Random().Next(100);

    }
    return arr;
}

void PrintArr(int[] arr){
    int arr_size = arr.Length;
    Console.Write("[");
    for(int i = 0;i <  arr_size - 1;i++){
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[arr_size - 1]}]");
}
