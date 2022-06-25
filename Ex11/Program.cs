//  Вход 2 числа, первое число является квадратом второго (да/нет) 
 Console.WriteLine("Введите первое число");
 string numberStrFirst = Console.ReadLine();
 int numberFirst = int.Parse(numberStrFirst);
 Console.WriteLine("Введите второе число");
 string numberStrSecond = Console.ReadLine(); //считывание стринговой переменной 
 int numberSecond = int.Parse(numberStrSecond); //парсим перемен стринг в перем инт
 if (numberFirst == numberSecond * numberSecond)
 {
    Console.WriteLine("Да");
 }
    else
    {
        Console.WriteLine("Нет");
    }
 
