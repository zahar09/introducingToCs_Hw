// See https://aka.ms/new-console-template for more information
Console.Clear();
int[] arr = GetArr();
int ans = CheckArr(arr);
Console.Write($"{String.Join(", ",arr)} -> {ans}");

int[] GetArr(){
    int n = new Random().Next(2,10);
    int[] arr = new int[n];
    for(int i = 0; i < n;i++){
        arr[i] = new Random().Next(100,1000);
    }
    return arr;
}

int CheckArr(int[] arr){
    int numbers = 0;
    for(int i = 0;i < arr.Length;i++){
        if(arr[i] % 2  == 0){
            numbers++;
        }
    }
    return numbers;
}