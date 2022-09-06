// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


// int [] array = new int [10];
// int size = array.Length;

// int count = 0;

// for(int i = 0; i<size; i++)
// {
//     array[i] = new Random().Next(100, 1000);

//     if(array[i]%2==0) count+=1;
// }

// Console.WriteLine(String.Join(";", array));
// Console.WriteLine("Четных чисел в массиве: "+count);



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


// int [] array = new int [10];
// int size = array.Length;

// int sumNumbers = 0;

// for(int i = 0; i<size; i++)
// {
//     array[i] = new Random().Next(-9, 10);
//     if(i%2==1) sumNumbers+=array[i];
// }
// Console.WriteLine(String.Join(";", array));

// Console.WriteLine("Сумма чисел на нечетных позициях = " + sumNumbers);


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


double[] array = new double[10];

for (int i = 0; i < array.Length; i++)
{
    array[i] =new Random().Next(-1000, 1001)*0.4;
}

double min = array.Min();
double max = array.Max();

Console.WriteLine(String.Join("; ", array));

Console.WriteLine("Разница между максимальным и минимальным элементами массива = " + (max-min));
