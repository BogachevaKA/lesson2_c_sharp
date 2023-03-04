
Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 100 & num > 999)
{
    Console.WriteLine("Введено не трёхзначное число");
    return;
}
int x1 = num / 10 % 10;
Console.WriteLine($"Второе число: {x1}");