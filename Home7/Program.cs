//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*int rows=3;
int columns=4;

double[,] GetArray(int m,int n)
{
    var array=new double[m,n];
    for (int i=0; i<m;i++)
    {
        for (int j=0; j<n;j++)
        {
            array[i,j]=new Random().NextDouble();
        }
    }

    return array;
}

void PrintArr(double[,] array)
{
    for (int i=0; i<array.GetLength(0);i++)
    {
        for (int j=0; j<array.GetLength(1);j++)
        {
            Console.Write($"{array[i,j]}");
        }
        System.Console.WriteLine();
    }
}

PrintArr(GetArray(rows,columns));
*/
//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*int rows=3;
int columns=4;

int[,] GetArray(int m,int n)
{
    var array=new int[m,n];
    for (int i=0; i<m;i++)
    {
        for (int j=0; j<n;j++)
        {
            array[i,j]=new Random().Next(10);
        }
    }

    return array;
}

void PrintArr(int[,] array)
{
    for (int i=0; i<array.GetLength(0);i++)
    {
        for (int j=0; j<array.GetLength(1);j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        System.Console.WriteLine();
    }
}

bool SearchElement(int[,] array, int elements)
{
    for (int i=0; i<array.GetLength(0);i++)
    {
        for (int j=0; j<array.GetLength(1);j++)
        {
            if(array[i,j]==elements) 
            {
                    return true;
            }
            
        }
        
    }
    return false;
}


var arr=GetArray(rows,columns);
foreach (var item in arr)
{
    System.Console.WriteLine(item);
}
System.Console.WriteLine(SearchElement(arr,9));
*/
//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int rows=3;
int columns=4;

int[,] GetArray(int m,int n)
{
    var array=new int[m,n];
    for (int i=0; i<m;i++)
    {
        for (int j=0; j<n;j++)
        {
            array[i,j]=new Random().Next(10);
        }
    }

    return array;
}

void PrintArr(int[,] array)
{
    for (int i=0; i<array.GetLength(0);i++)
    {
        for (int j=0; j<array.GetLength(1);j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        System.Console.WriteLine();
    }
}


double[] SumColumn(int[,] array)
{
    var result=new double[array.GetLength(1)];
    for (int i=0; i<array.GetLength(1);i++)
    {
        double sum=0;
        for (int j=0; j<array.GetLength(0);j++)
        {
            sum += array[j,i];
            
        }

        result[i]=sum/array.GetLength(0);        
    }

    return result;
}


foreach (var item in SumColumn(GetArray(rows,columns)))
{
    System.Console.WriteLine(item);
}