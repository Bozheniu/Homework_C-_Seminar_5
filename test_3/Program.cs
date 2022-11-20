/* Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным 
элементов массива.
[3 7 22 2 78] -> 76 */

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 21);
    }
}

int MaxVaule(int[] array)
{
    int maxVaule = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxVaule)
        {
            maxVaule = array[i];
        }
    }
    return maxVaule;
}

int MinVaule(int[] array)
{
    int minVaule = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minVaule)
        {
            minVaule = array[i];
        }
    }
    return minVaule;
}

int[] array = new int[10];
FillArray(array);

int Difference()
{
    int diff = MaxVaule(array) - MinVaule(array);
    return diff;
}

Console.WriteLine("Max = " + MaxVaule(array));
Console.WriteLine("Min = " + MinVaule(array));

Console.WriteLine("[" + string.Join(",", array) + "]" + " -> " + Difference());
