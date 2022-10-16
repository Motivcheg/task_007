//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.



Console.WriteLine("Введите число m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n ");
int n = Convert.ToInt32(Console.ReadLine());
string NumbersRec(int m,int n)
{
    if (m <= n) return $"{m} "+ NumbersRec(m+1,n);
    else return string.Empty;
}

Console.WriteLine(NumbersRec(m, n));