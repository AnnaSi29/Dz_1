//  1. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


Console.WriteLine("Задание 1. Введите размер массива: ");
int size = int.Parse(Console.ReadLine());

int[] numbers = new int[size];
int count = 0;
for (int i = 0; i < size; i++)
{
    numbers[i] = new Random().Next(99, 1000);
    Console.Write(numbers[i] + " ");
}
for (int even = 0; even < numbers.Length; even++)
{
    if (numbers[even] % 2 == 0)
    {
        count++;
    }
}
Console.WriteLine();
Console.WriteLine($"Количество четных чисел в массиве = {count}");


// 2. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


Console.WriteLine("Задание 2. Задайте одномерный массив, заполненный случайными числами.");

Console.WriteLine("Введите длину массива");
 int l = Convert.ToInt32(Console.ReadLine());
 int[] array = new int[l];
 int sum = 0;
 for(int i = 0; i < array.Length; i++){
     array[i] = new Random().Next(1, 101);
     Console.Write(array[i] + " ");
     if(i % 2 > 0) sum = sum + array[i];
}
 Console.WriteLine();
 Console.WriteLine(sum);

 
 // 3. Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}
int[] RandArray(int lenght)
{
    int[] answer = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        answer[i] = new Random().Next(1, 10);
    }
    return answer;
}
void PrintArray(int[] collect)
{
    Console.Write("[");
    for (int i = 0; i < collect.Length - 1; i++)
    {
        Console.Write(collect[i] + ",");

    }
    Console.Write(collect[collect.Length - 1] + "]");
}
int[] FindCompos(int[] arr, int len)
{
    int[] result = new int[len / 2];
    for (int i = 0; i < arr.Length / 2; i++)
    {
        result[i] = arr[i] * arr[arr.Length - i - 1];
    }
    return result;
}

int len = Prompt("Задание 3. Введите длину массива");
int[] arr = RandArray(len);
PrintArray(arr);
Console.WriteLine();
PrintArray(FindCompos(arr, len));


// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.WriteLine($"Задание 4. Найдите разницу между максимальным и минимальным элементов массива из вещественных чисел: ");
double[] arrayRealNumbers = new double[10];
for (int i = 0; i < arrayRealNumbers.Length; i++)
{
    arrayRealNumbers[i] = new Random().Next(1, 10);
    Console.Write(arrayRealNumbers[i] + " ");
}
double maxNumber = arrayRealNumbers[0];
double minNumber = arrayRealNumbers[0];
for (int i = 1; i < arrayRealNumbers.Length; i++)
{
    if (maxNumber < arrayRealNumbers[i])
    {
        maxNumber = arrayRealNumbers[i];
    }
    if (minNumber > arrayRealNumbers[i])
    {
        minNumber = arrayRealNumbers[i];
    }
}
double decision = maxNumber - minNumber;
Console.WriteLine($"Разница между между максимальным ({maxNumber}) и минимальным({minNumber}) элементами: {decision}");
