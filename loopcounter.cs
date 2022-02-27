using System;
//Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. Display the count on the console.

class Program {
  public static void Main (string[] args) 
  {
    int counter = 0;
    
    for ( var i = 0; i < 100; i++)
    {
     if(  i % 3 == 0){
     //Console.WriteLine(i);
      counter++;
      }
  
    }
    Console.WriteLine(counter);
  
      
  }
}