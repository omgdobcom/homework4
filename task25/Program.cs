//  Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA == 0 || numberB == 0)
{
    Console.WriteLine("Результат: 1");
}
else
{
    Console.WriteLine("Результат: " + Degree(numberA, numberB));
}
int Degree(int num1, int num2)

{
    int result = 1;
    for (int i = 0; i < num2; i++)
    {
        result = result * num1;
    }
    return result;
}
