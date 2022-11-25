// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumNumber(int num1)
{
    int result = 0;
    while(num1 > 0)
    {
        result = result + num1 % 10;
        num1 = num1 / 10;
    }
    return  result;
}

Console.WriteLine("Сумма всех цифр в числе: " + SumNumber(number));
