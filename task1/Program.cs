
Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num >= 100 & num <= 999)
{
    Console.WriteLine($"Второе число: {num / 10 % 10}");
}
//int x1 = num / 10 % 10;
else
{
    Console.WriteLine("Введено не трёхзначное число");
}