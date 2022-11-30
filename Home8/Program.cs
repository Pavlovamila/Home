//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*int rows=3;
int columns=4;

//Создание массива
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

//Вывод массива
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

// Функция сортировки элементов в строке двумерного массива, по убыванию
void SortToLower(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

var x=GetArray(rows,columns);
PrintArr(x);
System.Console.WriteLine();

SortToLower(x);
PrintArr(x);
*/
//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*int rows=4;
int columns=4;

//Создание массива
int[,] GetArray(int m,int n)
{
    var array=new int[m,n];
    for (int i=0; i<m;i++)
    {
        for (int j=0; j<n;j++)
        {
            array[i,j]=new Random().Next(5);
        }
    }

    return array;
}

//Вывод массива
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

void NumberRowMinSumElements(int[,] array)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minRow += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) sumRow += array[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.Write($"{minSumRow + 1} строка");
}

var x=GetArray(rows,columns);



PrintArr(x);
System.Console.WriteLine();


NumberRowMinSumElements(x);
*/
//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
int rows=2;
int columns=2;

//Создание массива
int[,] GetArray(int m,int n)
{
    var array=new int[m,n];
    for (int i=0; i<m;i++)
    {
        for (int j=0; j<n;j++)
        {
            array[i,j]=new Random().Next(5);
        }
    }

    return array;
}

//Вывод массива
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
var matrix1=GetArray(rows,columns);
var matrix2=GetArray(rows,columns);

static int[,] DivMatrix(int[,] matrix1, int[,] matrix2)
{
    var matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    if (matrix1.GetLength(1) == matrix2.GetLength(0))
    {
        for (int i = 0; i < matrix3.GetLength(0); i++)
        {
            for (int j = 0; j < matrix3.GetLength(1); j++)
            {
                matrix3[i, j] = 0;
                for (int n = 0; n < matrix1.GetLength(1); n++)
                {
                    matrix3[i, j] += matrix1[i, n] * matrix2[n, j];
                }
            }
        }
    }
    return matrix3;
}




var div=DivMatrix(matrix1, matrix2);

System.Console.WriteLine("Матрица А ");
PrintArr(matrix1);
System.Console.WriteLine("Матрица Б ");
PrintArr(matrix2);


System.Console.WriteLine();
PrintArr(div);

//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
