// Показать кубы чисел, заканчивающихся на четную цифру
int [] array = new int [8];
for (int i = 0; i < array.Length; i++) array [i] = new Random().Next(1,10);
for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]} ");
Console.WriteLine();
int cub = 0;
Console.WriteLine("Кубы чисел массива, заканчивающихся на четную цифру: ");
for (int i = 0; i < array.Length; i++)
{
if (array[i] % 2 == 0)
{
    cub = array[i] * array[i] * array[i];
    Console.WriteLine(cub);
}
}


