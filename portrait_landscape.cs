using System;
//Write a program and ask the user to enter the width and height of an image. Then tell if the image is landscape or portrait.

class Program {
  public static void Main (string[] args) {

    string width = "";
    string height = "";
    
    Console.WriteLine ("Enter Width");

      width = Console.ReadLine();
      
    
     Console.WriteLine ("Enter Height");
    
    height = Console.ReadLine();
   
    int width_number = 0;
    width_number = Int16.Parse(width);

    int height_number = 0;
    height_number = Int16.Parse(height);

    if (width_number < height_number)
    {
      Console.WriteLine("Portrait");
     }
    else 
      {
      Console.WriteLine("Landscape");
      }
     
  }
}