//Home
//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*int[] GetArray(int size,int min,int max)
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
*/
//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

/*
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
    int sumi=0;
    for(int i=1 ;i<array.Length;i=i+2)
    {
        
        sumi=sumi+array[i];
        
        
    }
    return sumi;
}

int[] arr=GetArray(4,-10,10);

Console.WriteLine(string.Join(", ",arr));
Console.WriteLine($"Sum not even nums:"+ GetElement(arr));
*/
//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
double[] GetArray(int size,int min,int max)
{
    double[] array=new double[size];
    Random rand=new Random();
    for (int i=0; i<array.Length;i++)
    {
        array[i]=rand.Next(min,max+1)/10.0;
    }

    return array;
}

double ResultArr(double[] array)
{
    double result=0;
    double min=array[0];
    double max=array[0];
    for (int i=0; i<array.Length;i++)
    {
        if(array[i]>max)
        {
            max=array[i];
        }
        if(array[i]<min)
        {
            min=array[i];
        }
    }
    result=max-min;
    return result;
}


double[] arr=GetArray(4,1,100);

Console.WriteLine(string.Join(", ",arr));
Console.WriteLine($"Разница между max и min: "+ ResultArr(arr));

