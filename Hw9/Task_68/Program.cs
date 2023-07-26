Console.Write("Введите число N: ");
uint number1 = uint.Parse(Console.ReadLine());
Console.Write("Введите число M: ");
uint number2 = uint.Parse(Console.ReadLine());
Console.WriteLine(A(number1,number2));
uint A(uint n, uint m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return A(n - 1, 1);
    else
      return A(n - 1, A(n, m - 1));
}