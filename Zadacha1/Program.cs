// Показать таблицу квадратов чисел от 1 до N
Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine()??"");
int square = 1;
Console.WriteLine($"Квадраты чисел от 1 до {N}: ");
for (int i = 1; i <= N; i++)
{
    square = i * i;
    Console.Write($"{square}  ");
}
