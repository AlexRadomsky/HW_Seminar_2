// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. 
Console.Write("Enter a day of week: "); 
try {
  int Day = Convert.ToInt32(Console.ReadLine()); 
  if (Day >= 1 && Day <=7) { 
    if (Day >= 6) { 
      Console.Write("Woohoo... It's a holiday"); 
    } else { 
      Console.Write("It's a working day"); 
    } 
  } else { 
    Console.Write("Enter a valid day between 1 and 7"); 
  }
} catch (Exception e) {
  Console.WriteLine(e.Message);
}