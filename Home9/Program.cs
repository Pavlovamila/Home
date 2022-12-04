//Обьявления массива
string[] myArray = { "123", "1567", "-2", "435tret" };
//Вывод массива
string str = string.Join(", ", myArray);
Console.Write($"[{str}] -> ");
int j = 1;
//Длина массива  j <=3
for (int i = 0; i < myArray.Length; i++)
{   
    //Проверка ячейку массива на <=3
    if (myArray[i].Length <= 3)
    {        
            
            Console.Write($"{myArray[i]}, "); 
            j++;
               
    }
}
//Обьявления массива меньше <=3
string[] myArrayThree = new string[j];

j=0;

//Формирования нового массива
for (int i = 0; i < myArray.Length; i++)
{   
    if (myArray[i].Length <= 3)
    {        
            
            
            myArrayThree[j]=myArray[i]; 
            j++;
               
    }
}

string str2 = string.Join(" ", myArrayThree);
Console.WriteLine($"Новый массив: {str2} ");