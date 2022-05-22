// Подсчитать сумму цифр в числе
Console.WriteLine("Введите число для подсчета цифр: ");
int A = int.Parse(Console.ReadLine()??"");
int summa = 0;
while (A > 0)
{
    summa = summa + A % 10;
    A = A / 10;
}
Console.WriteLine($"Сумма цифр числа равна {summa}");
