// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// way 1
// Console.Write("Введите число: ");
// double num = Convert.ToDouble(Console.ReadLine());

// Console.Write("Введите натуральную степень: ");
// int degree = Convert.ToInt32(Console.ReadLine());

// if (degree>0 && degree % 1 == 0) Console.WriteLine("Результат: " + Math.Pow(num,degree));

// else Console.WriteLine("Вы ввели ненатуральную степень");

// way2

Console.Write("Введите число: ");
double num = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите натуральную степень: ");
int degree = Convert.ToInt32(Console.ReadLine());

double Product(double number, int count)
{   
    double result = number;
    for (int i = 1; i < count; i++) result= result * number;
    return result;
}

Console.WriteLine("Результат: " + Product(num, degree));