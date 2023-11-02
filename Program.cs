//приложение, которое принимает с клавиатуры два числа и действие между ними, а потом вводит результат
using System;

class ConsoleCalculatorApp // класс приложения (это база)
{
  #region Создание переменных
  static double num;//число 
  static double num2;//2 число
  static string act;//действие между двумя действиями
  #endregion
  static void Info()
  {  //метод для отображения начальной информации
    Console.WriteLine("--------- К А Л Ь К У Л Я Т О Р ----------");
    Console.WriteLine("Введите с помощью клавиатуры и Enter первое число,");
    Console.WriteLine("затем дейстивие и если требуется второе число.");
    Console.WriteLine("Поддерживаемые действия: +, -, *, /, **,  sqrt, sin, cos.");
    Console.WriteLine("");
  }

  static void Arguments()
  { //метод для полячения чисел и типа операции между ними
    try //обработка исключений
    {
      Console.WriteLine("введите число:");
      num = Convert.ToDouble(Console.ReadLine());

      Console.WriteLine("введите действие");
      act = Console.ReadLine();
      if (act == "+" || act == "-" || act == "*" || act == "/" || act == "**")
      {
        Console.WriteLine("введите 2 число:");
        num2 = Convert.ToDouble(Console.ReadLine());
      }
    }
    catch
    {
      Console.WriteLine("такое действие не поддерживается!");
      Arguments();
    }
  }
  static void Calculation()
  { //метод для расчета результата
    if (act == "+")
    {
      Console.WriteLine($"результат сложения чисел {num} и {num2}:");
      Console.WriteLine((num + num2).ToString());
    }
    else if (act == "-")
    {
      Console.WriteLine($"результат вычетания чисел {num} и {num2}:");
      Console.WriteLine((num - num2).ToString());
    }
    else if (act == "*")
    {
      Console.WriteLine($"результат умножения чисел {num} и {num2}:");
      Console.WriteLine((num * num2).ToString());
    }
    else if (act == "/")
    {
      Console.WriteLine($"результат деления чисел {num} и {num2}:");
      Console.WriteLine((num / num2).ToString());
    }
    else if (act == "**")
    {
      Console.WriteLine($"результат возведения числа {num} в степень {num2}:");
      Console.WriteLine(Math.Pow(num, num2).ToString());
    }
    else if (act == "sqrt")
    {
      Console.WriteLine($"результат извлечения квадратного корня из числа {num}:");
      Console.WriteLine(Math.Sqrt(num).ToString());
    }
    else if (act == "cos")
    {
      Console.WriteLine($"косинус числа {num} равен:");
      Console.WriteLine(Math.Cos(num).ToString());
    }
    else if (act == "sin")
    {
      Console.WriteLine($"синус числа {num} равен:");
      Console.WriteLine(Math.Sin(num).ToString());
    }
    else
    {
      Console.WriteLine("Такое действие не поддерживается");
    }
  }
  static void Reply()
  { //метод для повторения программы
    Console.WriteLine("");
    Console.WriteLine("продолжить работу? ");
    Console.WriteLine("введите 'да', чтобы продолжить ");
    Console.WriteLine("любой другой ввод закроет программу");
    if (Console.ReadLine() == "да")//вводим ответ на вопрос
    {
      Main(); //в случае положительного ответа вызывется главный цикл
    }
  }

  static void Main()
  { //основной метод, запускающая остальные методы
    Info(); //метод для отображения начальной информации
    Arguments(); //метод для полячения чисел и типа операции между ними
    Calculation(); //метод для расчета результата 
    Reply(); //метод для повторения программы
  }
}
