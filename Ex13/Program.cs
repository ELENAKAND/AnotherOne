// На входе число N - на выходе значения от -N до N 
Console.WriteLine("Введите число");
string numberStr = Console.ReadLine();
int number1 = int.Parse(numberStr); //спарсили стринг пользователя в инт 
int number2 = -number1; //присвоили отрицательное значение второму числу 
for (int i = number2; i <= number1; i++)
{
    Console.WriteLine(i);
}
