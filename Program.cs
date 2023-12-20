using System;

System.Console.WriteLine("Tyre 1st number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Tyre 2st number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"1st number is greater than 2nd number{firstNumber > secondNumber}");
System.Console.WriteLine($"Number 1 is less than number 2{firstNumber < secondNumber}");
System.Console.WriteLine($"1 number is less than or equal to 2 numbers{firstNumber <= secondNumber}");
System.Console.WriteLine($"1 number is greater than or equal to 2 numbers{firstNumber >= secondNumber}");
System.Console.WriteLine($"Is number 1 equal to number 2?{firstNumber == secondNumber}");
System.Console.WriteLine($"1 number is not equal to 2 numbers{firstNumber != secondNumber}");


