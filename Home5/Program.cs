//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных элементов массива.
/*
int[]CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array;    
}

void ShowArray(int [] array)
{
    Console.Write("Array is: ");
    for(int i = 0; i < array.Length; i ++)
        Console.Write(array[i] + " ");
    Console.Write(" \n");
}
int GetNegativeSum(int[] array)
{
        int sum = 0;
        for(int i = 0; i < array.Length; i ++)
        if(array [i] < 0)
            sum += array[i];
    
    return sum;
}
Console.Write("Input a number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(n, min, max);
ShowArray(myArray);

int negativeSum = GetNegativeSum(myArray);
Console.WriteLine("Sum of negative elemints is " + negativeSum);
*/
//Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве
//2 45 1 78 35 64 32
//15 56
/*int[]CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array;    
}

void ShowArray(int [] array)
{
    Console.Write("Array is: ");
    for(int i = 0; i < array.Length; i ++)
        Console.Write(array[i] + " ");
    Console.Write(" \n");
}
bool FindNumber (int [] array, int num)
{
    for(int i = 0; i < array.Length; i ++)    
        if(num == array[i]0 
            return true;
        
    return false;    
} 
Console.Write("Input a number of elements: ");
int num = Convert.ToInt32(Console.ReadLine());
booi resuit= FindNumber(myArray, num);
    if (result == true)
    
Console.Write(Console.ReadLine());
int num = Convert.ToInt32(Console.ReadLine());
*/
//Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот

//
/*int[]CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array;    
}
void F(int a)
{
    a += 5;
}
int num = 5;
F(num);
Console.WriteLine(num);
*/


//Home
//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] GetArray(int size,int min,int max)
{
    int[] array=new int[size];
    Random rand=new Random();
    for (int i=0; i<array.Length;i++)
    {
        array[i]=rand.Next(min,max+1);
    }

    return array;
}

int GetElement(int[] array)
{
    int sum=0;
    for(int i=0;i<array.Length;i++)
    {
        if(array[i]%2 ==0)
        {
            sum++;
        }
        
    }
    return sum;
}

int[] arr=GetArray(10,100,999);

Console.WriteLine(string.Join(", ",arr));
Console.WriteLine($"Even nums: "+ GetElement(arr));

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76