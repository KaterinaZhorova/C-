Console.Write("введите число namber1: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("введите число namber2: ");
int number2 = int.Parse(Console.ReadLine());
if(number1 > number2);
{
    Console.WriteLine ($"максимальное число ({number1}) минимальное число ({number2})");
}
if(number2 > number1);
{ 
    Console.WriteLine($"минимальное число({number2}) максимальное число ({number1})");    
}