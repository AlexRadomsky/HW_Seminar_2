// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
Console.Write("Enter a number: "); 
try {
  int number = Convert.ToInt32(Console.ReadLine()); 
  int Length = number.ToString().Length; 
  if (Length >= 3) { 
    while (number > 999) 
    { 
      number = number / 10; 
    } 
    int result = number % 10; 
    Console.WriteLine("The third digit is " + result); 
  } else { 
    Console.WriteLine("The number contains less than 3 digits"); 
  }
} catch (Exception e) {
	Console.WriteLine(e.Message);
}