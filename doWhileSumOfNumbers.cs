using System;
//Write a program and continuously ask the user to enter a number or "ok" to exit. Calculate the sum of all the previously entered numbers and display it on the console.

class Program {
  public static void Main (string[] args) 
{

var userInput = "";
int number = 0;
    
do 
{
  Console.WriteLine("enter a number or ok");
  userInput = Console.ReadLine();
  if (userInput == "ok")
    break;
  var convertedNumber = Int16.Parse(userInput);
  
  if (convertedNumber >= 0 )
    number = number + convertedNumber;
}

while (userInput != "ok");
Console.WriteLine("your total sum is " + number);   

  }
}