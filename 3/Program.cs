// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите цифру, обозначающую день недели от 1 до 7");
string Number = Console.ReadLine()!;
int NumberIn=Convert.ToInt32(Number);
if (NumberIn<1||NumberIn>7)
{
  Console.WriteLine("Цифа выходит за заданный диапазон. Введите цифру от 1 до 7");  
}
else if (NumberIn==7||NumberIn==6)
{
    Console.WriteLine("Введенный день является выходным");
}
else
{
    Console.WriteLine("Введенный день является будним днем");
}