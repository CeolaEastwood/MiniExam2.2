using System;

class MainClass {

public static double DetermineHypotenuse(double side1, double side2)
  {  
    double DetermineHypotenuse=0;

    DetermineHypotenuse = Math.Sqrt((side1 * side1) + (side2*side2));
    
    return DetermineHypotenuse;
   
  }

public static void Main (string[] args){

  Console.WriteLine("How many triangles to calculate?");
  double n = Convert.ToDouble(Console.ReadLine());

  for (int i=0; i<n;i++)
   {
    Console.WriteLine("What is side 1?");
    double num1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("What is side 2?");
    double num2 = Convert.ToDouble(Console.ReadLine());

    double hypotenuse = DetermineHypotenuse(num1, num2);

    Console.WriteLine("The hypotenuse is " + hypotenuse);
    }
  

 }
  
  
}