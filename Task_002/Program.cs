// Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.

Console.Clear();

Console.Write("Введите своё число: ");
int EnterNumber = int.Parse(Console.ReadLine());

int result = 0;

while (EnterNumber != 0)
{
    result += EnterNumber % 10;
    EnterNumber /= 10;
}

Console.WriteLine($"Сумма цифр числа равна {result}.");
