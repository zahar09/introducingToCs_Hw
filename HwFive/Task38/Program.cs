//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.Clear();
Console.Write("Введите элементы массива через пробел: ");
string elements = Console.ReadLine();
double[] arr = GetArrayFromString(elements);
double ans = GetAns(arr);
Console.Write($"{String.Join(", ",arr)} -> {ans}");

double[] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    double[] res = new double[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = Convert.ToDouble(nums[i]);
    }
    return res;
}

double GetAns(double[] array){
    double ans = 0;
    double min = array[0];
    double max = array[0];
    for(int i = 0; i < array.Length;i++){
        if(array[i] > max){
            max = array[i];
        }
        else if(array[i] < min){
            min = array[i];
        }
    }
    ans = max - min;
    return ans;
}