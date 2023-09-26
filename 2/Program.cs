// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите  число");
string Number = Console.ReadLine()!;
int NumberIn=Convert.ToInt32(Number);
if (NumberIn>100)
{
  while (NumberIn>999)
  {
    NumberIn/=10;
  }
  NumberIn%=10;
  Console.WriteLine($"Третья цифра  числа равна {NumberIn}");
}
else
{
  Console.WriteLine("Третьей цифры в числе нет");  
}