// Найти кубы чисел от 1 до N
Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine()??"");
int cub = 0;
Console.WriteLine("Кубы чисел от 1 до N: ");
for (int i = 1; i <= N; i++)
{
    cub = i * i * i;
    Console.WriteLine(cub);
}
