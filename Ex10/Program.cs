/*
Вход число, выход квадрат числа
*/
Console.WriteLine("Введите число");
string numberStr = Console.ReadLine();
int number = int.Parse(numberStr);
int result = number * number;
Console.WriteLine($"Квадрат числа {number} равен {result}"); 
// Знак $ позволяет выводить в строке числовые переменные, нужны фигурные скобки 
