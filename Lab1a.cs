using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      //declare variables
      int varInt1 = 5; //defines an integer
      int varInt2 = 3;//defines an integer
      int varInt3 = 6;//defines an integer
      string myStr = "hello"; //defines a string
      bool myBool = true; //defines a boolean
      double myFloat = 5.98; //defines a float number
      char myChar = 'c'; //defines a character

      //present variables
      Console.WriteLine(varInt1); //output the variable
      Console.WriteLine(varInt2); //output the variable
      Console.WriteLine(varInt3); //output the variable
      Console.WriteLine(myStr); //output the variable
      Console.WriteLine(myBool); //output the variable
      Console.WriteLine(myChar); //output the variable
      Console.WriteLine(myFloat); //output the variable

      //preform arithmetic operations
      Console.WriteLine(varInt1 + varInt1); //5+5 = 10
      Console.WriteLine(varInt1 - varInt2); //5-3 = 2
      Console.WriteLine(varInt1 * varInt3); //5*6 = 30
      Console.WriteLine(varInt3 / varInt2); //6/3 = 2
      Console.WriteLine(varInt1 % varInt2); //5/3 the remainder is 2
      Console.WriteLine(varInt1++); //5 incremented once = 6
      Console.WriteLine(varInt1--); //5 decremented once = 4

      //preform assignment operations
      Console.WriteLine(varInt1 += 3); //5+3 = 8 and now 8 is the assigned value of varInt1
      Console.WriteLine(varInt1 -= 3); //8-3 = 5
      Console.WriteLine(varInt1 *= 3); //5*3 = 15
      Console.WriteLine(varInt1 /= 3); //15/3 = 5
      Console.WriteLine(varInt1 %= 3); //5%3 = 2
      varInt1 = 5; //resetting the value of varInt1

      //preform comparison operations
      Console.WriteLine(varInt1 == varInt1); //checks wether or not the varibles equal each other
      Console.WriteLine(varInt1 != varInt2); //cheack wether or not the varibles do not equal each other
      Console.WriteLine(varInt1 > varInt3); //checks to see if the first variable is greater than the second
      Console.WriteLine(varInt1 < varInt3); //checks to see if the first variable is less than the second
      Console.WriteLine(varInt1 >= varInt1); //checks to see if the first variable is greater than or equal to the second
      Console.WriteLine(varInt1 <= varInt1); //checks to see if the first variable is less than or equal to the second

      //preforms logical operations
      Console.WriteLine(varInt1 < 6 && varInt3 < 8); //if both values are true than it returns true
      Console.WriteLine(varInt1 < 8 || varInt3 < 6); //if at least one value is true than it returns true
      Console.WriteLine(!(varInt1 < 8 || varInt3 < 6)); //returns the opposite of the result
     }
  }
}