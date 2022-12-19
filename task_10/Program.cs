// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 
Console.Write("Enter a 3-digit number: "); 
try {
  int number = Convert.ToInt32(Console.ReadLine()); 
  int Length = number.ToString().Length; 
  if (Length == 3) { 
    int result = ( number/10 ) % 10; 
    Console.WriteLine($"The second digit is {result}"); 
  } else { 
    Console.WriteLine("Not a 3-digit number"); 
  }
} catch (Exception e) {
	Console.WriteLine(e.Message);
}