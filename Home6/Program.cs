//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь

Console.Write("Enter the elements (separated by a space): ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;
 
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}
 
Console.WriteLine($"Кол-во элементов > 0: {count}");

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
/*
Console.WriteLine("Input num b1");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input num k1");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input num b2");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input num");
double k2 = Convert.ToDouble(Console.ReadLine());

double[] Point(double b1,double k1,double b2,double k2) 
{
    double[] result=new double[2];
    result[0]=(b2-b1)/(k1-k2);
    result[1]=k1*result[0]+b1;

    return result;
}
Console.WriteLine(string.Join(" ",Point(b1,k1,b2,k2)));
*/