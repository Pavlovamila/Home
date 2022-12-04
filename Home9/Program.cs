int[] GetEvenArray(int[] inputArr) // Возращает новый массив в котором содержаться четные числа исходного массива
{
    int[] resultArr = new int[inputArr.Length];
    int j = 0;
    for (int i = 0; i < inputArr.Length; i++)
        if (inputArr[i] % 2 == 0)
        {
            resultArr[j] = inputArr[i];
            j++;
        }
    Array.Resize(ref resultArr, j);
    return resultArr;
}

void PrintArray(int[] arr, string preStr = "", string postStr = "\n") // Выводит на экран элементы массива через запятую
{
    Console.Write(preStr);
    for (int i = 0; i < arr.Length; i++)
        if(i != arr.Length - 1) Console.Write($"{arr[i]}, ");
        else                    Console.Write($"{arr[i]}");
    Console.Write(postStr);
}

void FillRandomArray(int[] arr, int minVal, int maxVal) // Возращает заполненный псевдослучайными числами [minVal;maxVal) массив
{
    for (int i = 0; i < arr.Length; i++)
        arr[i] = new Random().Next(minVal, maxVal);
}

bool IsEqualArray(int[] arrA, int[] arrB) // Сравнивает поэлементно два массива: True - идентичны, False - отличаются.
{
    if (arrA.Length != arrB.Length) return false;
    else
    {
        for (int i = 0; i < arrA.Length; i++)
            if (arrA[i] != arrB[i]) return false;
    }
    return true;
}

Console.Clear();