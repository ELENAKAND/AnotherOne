// На ввод трехзначное число - на вывод последняя цифра 
Console.WriteLine("Введите трехзначное число");
string numberStr = Console.ReadLine();
int number = int.Parse(numberStr);
if (number > 99 && number < 1000)
{
    Console.WriteLine(number%10);
}
else 
{
    Console.WriteLine("Это не трехзначное число");
}
