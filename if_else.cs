using System;
//number from 1 to 10, if 1 to 10 print 'valid',else print 'invalid'
class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Please enter a number between 1 and 10");
    string numberEntered = "";
    numberEntered = Console.ReadLine();
    Console.WriteLine(numberEntered);

    int number = 0;
    number = Int16.Parse(numberEntered);

    if (number >0 && number <11)
    {
      Console.WriteLine("valid");
     }
    else 
      {
      Console.WriteLine("invalid");
      }
     
  }
}