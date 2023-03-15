// Задача 64: Задайте значения M и N. 
// Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.

// M = 1; N = 5 -> 2, 4
// M = 4; N = 8 -> 4, 6, 8

Console.Clear();

void GetNaturalNumber (int M, int N)
{
    if(M > N) return;
    Console.Write($"{M} ");
    GetNaturalNumber(M + 1, N);
}


Console.WriteLine("Введите число M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());

GetNaturalNumber(m, n);