Console.WriteLine("Введите три числа");
Console.Write("Введите первое число");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе");
int number2 = int.Parse(Console.ReadLine());
Console.Write("Введите третье");
int number3 = int.Parse(Console.ReadLine());
int maxNumber = 0;
if (number1 > maxNumber) maxNumber = number1;
if (number2 > maxNumber) maxNumber = number2;
if (number3 > maxNumber) maxNumber = number3;
Console.Write("Максимальное значение имеет число " + maxNumber);