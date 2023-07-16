/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

Console.Write("Введите числа через пробел: ");
string numbers_string = Console.ReadLine();

int[] arr = CreatArrFromString(numbers_string);
int quantity = CountNumbers(arr);

Console.WriteLine(quantity);


int[] CreatArrFromString(string string_arr){
    string[] arr = string_arr.Split(" ");
    int[] numbers = new int[arr.Length];
    for(int i = 0;i < numbers.Length;i++){
        numbers[i] = int.Parse(arr[i]);
    }
    return numbers;
}

int CountNumbers(int[] array){
    int quantity = 0;
    for(int i = 0;i < array.Length;i++){
        if(array[i] > 0){
            quantity++;
        }
    }
    return quantity;
}





