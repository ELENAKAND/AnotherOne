﻿// Using if/else 
Console.WriteLine("Введите свое имя: ");
string username = Console.ReadLine();
  if(username.ToLower() == "Маша")
  {
      Console.WriteLine("Ура, это Маша!");
  }
  else
  {
      Console.WriteLine("Привет, ");
      Console.WriteLine(username);
  }