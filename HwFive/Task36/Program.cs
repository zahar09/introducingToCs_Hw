//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
Console.Clear();
int[] arr = GetArr();
int ans = GetSum(arr);
Console.Write($"{String.Join(", ",arr)} -> {ans}");

int[] GetArr(){
    int n = new Random().Next(2,10);
    int[] arr = new int[n];
    for(int i = 0; i < n;i++){
        arr[i] = new Random().Next(1,10);
    }
    return arr;
}

int GetSum(int[] array){
    int sum = 0;
    for(int i = 0;i < array.Length; i++){
        if(i%2 != 0){
            sum += array[i];
        }
    }
    return sum;
}