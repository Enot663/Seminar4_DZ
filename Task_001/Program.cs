// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.

Console.Clear();

Console.WriteLine("Для формулы A в степени B");
Console.Write("Введите число A: ");
int EnterNumberA = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int EnterNumberB = int.Parse(Console.ReadLine());

int result = EnterNumberA;

for (int i = 2; i <= EnterNumberB; i++)
{
    result *= EnterNumberA;
}

Console.WriteLine($"Число {EnterNumberA} в {EnterNumberB} степени равно {result}");
