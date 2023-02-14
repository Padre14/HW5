// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
Console.WriteLine ("Task 34");
int[]array = GetArray(5, 100, 999);
System.Console.WriteLine(String.Join(" ", array));

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int [size];
    for (int i = 0; i < size; i++)
    {
         res[i] = new Random().Next(minValue, maxValue+1);
    }
    return res;
}

int EvenCount(int[] massiv)
{
    int count = 0;сдук
    for (int index = 0; index < array.Length; index++)
    {
        if (array[index]%2==0)
        {
            count++;
        }
    }
    return count;
}
System.Console.WriteLine($" {EvenCount(array)}");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//  0  1   2   3
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
Console.WriteLine ("Task 36");
int[]massiv = GetArray(5, 100, 999);
System.Console.WriteLine(String.Join(" ", array));

int SumOdd(int[] massiv)
{
    int sum = 0;
    for (int index = 0; index < array.Length; index++)
    {
        if(index%2>0)
        {
            sum =array[index] + sum;
        }
    }
    return sum;
}
System.Console.WriteLine($" {SumOdd(array)}");


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
Console.WriteLine ("Task 38");
double[]array2 = GetMassiv(5, 0, 10);
System.Console.WriteLine(String.Join(" ", array2));
double[] GetMassiv(int size, int minValue, int maxValue)
{
    double[] res = new double [size];
    var rand = new Random();
    for (int i = 0; i < size; i++)
    {
         res[i] = Convert.ToDouble(rand.Next(-100, 100)/10.0);
         
    }
    return res;
}

double Max(double[] massiv)
{
    double max=0;
    for (int index = 0; index < array.Length; index++)
    {
        if(massiv[index]>max)
        {
            max = massiv[index];
        }
    }
    return max;
}

double Min(double[] massiv)
{
    double min=1;
    for (int index = 0; index < array.Length; index++)
    {
        if(massiv[index]<min)
        {
            min = massiv[index];
        }
    }
    return min;
}
System.Console.WriteLine($" {Max(array2)}");
System.Console.WriteLine($" {Min(array2)}");
double result = Max(array2) - Min(array2);
System.Console.WriteLine($" {result}");



