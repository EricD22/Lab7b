using System;

class Program {

public static double IntegerPower(double x, double y)
{
double ans =1;//set ans to 1 as we are multiplying in the equation. 0 will make your answer 0 always

for (int num =1;num <= y; num++) //start loop at 1 
  //not necessary
  ans = ans*x;//ans = ans * x;

  

return ans;//you need these parantheses. Move the if conditions inside these parantheses
 

  
}
  
  public static void Main (string[] args) {
    double ans =0;
    Console.WriteLine ("Please input base number");

    double x = Convert.ToDouble(Console.ReadLine());

  Console.WriteLine("Please input exponent power ");
  double y = Convert.ToDouble (Console.ReadLine());

   ans = IntegerPower(x,y);
      Console.WriteLine("The value is " + ans);
  }
}