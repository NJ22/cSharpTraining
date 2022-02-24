using System;
//Write a program which takes two numbers from the console and displays the maximum of the two.

class Program {
  public static void Main (string[] args) {

    string firstNumber = "";
    string secondNumber = "";
    
    Console.WriteLine ("Please enter your first number");

      firstNumber = Console.ReadLine();
      
    
     Console.WriteLine ("Please enter your second number");
    
    secondNumber = Console.ReadLine();
   
    int number1 = 0;
    number1 = Int16.Parse(firstNumber);

       int number2 = 0;
    number2 = Int16.Parse(secondNumber);

    if (number1 > number2)
    {
      Console.WriteLine(number1);
     }
    else 
      {
      Console.WriteLine(number2);
      }
     
  }
}