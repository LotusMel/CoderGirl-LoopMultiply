using System;

namespace LoopMultiply
{
    public static class Program
    {
        public static void Main()
        {
            Console.Write("Enter a number: ");
            string userInput = Console.ReadLine();

            int input = int.Parse(userInput);
            int sum = 0;
            Console.WriteLine("These are all the products" + 
                " of the number you entered" + 
                " multiplied by each number ranging from 2 to 20.");
            
           
           for(int number = 2; number < 21; number++)
            {
                
                int product = input * number;
                Console.WriteLine("{0} * {1} = {2}", input, number, product);
                

                sum = sum + product;
            }


            Console.WriteLine("And the sum of all products is: " + sum + ".");
            Console.ReadLine();


            // TODO: Loop from 2 to 20 and multiply the loop value by the number the user entered and output the value each time. 

            // TODO: When the loop is finished, output the sum of all previous values.

            
        }
    }
}
