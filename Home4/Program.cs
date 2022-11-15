//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
/*Console.Write("Enter a number A: ");
  int A = Convert.ToInt32(Console.ReadLine());
  Console.Write("Enter a number B: ");
  int B = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Answer: " + exp(A, B));

int exp(int A, int B){
  int result = 1;
  for(int i=1; i <= B; i++){
    result = result * A;
  }
    return result;
}
*/

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

/*Console.Write("Введите число: ");
  int A = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Сумма всех чисел числа:" + sum(A));

int sum(int A){
    
    int length = Convert.ToString(A).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < length; i++){
      advance = A - A % 10;
      result = result + (A - advance);
      A = A / 10;
    }
   return result;
  }
  */
//**Задача** 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
/*
int [] GArr(int size=8){
    int[] arr=new int[size];
    for (int i=0; i<arr.Length;i++){
        arr[i]=new Random().Next(100);
    }

    return arr;
}

foreach (var item in GArr()){
Console.WriteLine(item);
}
*/
