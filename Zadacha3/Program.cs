// Найти сумму чисел от 1 до А
Console.WriteLine("Введите число A: ");
int A = int.Parse(Console.ReadLine()??"");
int sum = 0;
Console.WriteLine("Сумма чисел от 1 до A: ");
for (int i = 1; i <= A; i++)
{
    sum = sum + i;
}
Console.Write(sum);