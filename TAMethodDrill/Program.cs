using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAMethodDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What number would you like to use?");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int addResult;
            int subResult;
            int divResult;

            Math math = new Math();
            addResult = math.Addition(num1);
            subResult = math.Subtraction(num1);
            divResult = math.Division(num1);
            Console.WriteLine("Your number plus 2 is : {0}", addResult);
            Console.WriteLine("Your number minus 2 is : {0}", subResult);
            Console.WriteLine("Your number divided by 2 is : {0}", divResult);
        
            Console.ReadLine();
        }
    }
}

//1. Create a class. In that class, create three methods, each of which will 
//   take one integer parameter in and return an integer.The methods should 
//   do some math operation on the received parameter.Put this class in a 
//   separate.cs file in the application.

//2. In the Main() program, ask the user what number they want to do the math
//   operations on.

//3. Call each method in turn, passing the user input to the method.Display 
//   the returned integer to the screen.