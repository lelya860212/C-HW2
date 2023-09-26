// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число");
string Number = Console.ReadLine()!;
int NumberIn=Convert.ToInt32(Number);
if (NumberIn<100||NumberIn>999)
{
  Console.WriteLine("Введите трехзначное число");  
}
else
{
    int numder=(NumberIn/10)%10;
    Console.WriteLine($"Вторая цифра трехзначного числа равна {numder}");
}
