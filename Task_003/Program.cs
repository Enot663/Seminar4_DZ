// Напишите программу, которая задаёт массив из 8 элементов
// и выводит их на экран.
Console.Clear();

Console.Write("Введите число элементов массива: "); // 
int EnterNumber = int.Parse(Console.ReadLine());

int[] array = new int[EnterNumber];


for (int i = 0; i < EnterNumber; i++)
{
    array[i] = new Random().Next(0, 100);
    Console.Write(array[i] + "; ");
}

