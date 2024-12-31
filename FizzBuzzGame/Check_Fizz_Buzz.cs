using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzGame
{
   public class Check_Fizz_Buzz
    {
        public string Check_Game(int given_number)
        {
            string message = "";
            int Check_forFizz = given_number;
            int Check_forBuzz = given_number;
            int Contains_Fizz = given_number;
            int Contains_Buzz = given_number;

            // checking the given number is divisible by 5
            // if it is divisible, then check how many times 
            // example 50 --> 50 / 5 = 10
            // 10 / 5 --> 2 
            // 50 is divisible by 5 twice
            if (Check_forFizz % 5 == 0)
            {
                message = string.Concat(message, "Fizz ");
                while (Check_forFizz >= 5)
                {
                    Check_forFizz = Check_forFizz / 5;
                    if (Check_forFizz % 5 == 0)
                        message = string.Concat(message, "fizz ");
                }
            }

            // checking whether the given number contains 5
            while (Contains_Fizz > 0)
            {
                int temp = Contains_Fizz % 10;
                if (temp == 5)
                {
                    if (message.Contains("Fizz "))
                        message = string.Concat(message, "fizz ");
                    else
                        message = string.Concat(message, "Fizz ");
                }
                Contains_Fizz = Contains_Fizz / 10;
            }

            // checking the given number is divisible by 7
            // if it is divisible, then check how many times 
            if (Check_forBuzz % 7 == 0)
            {
                message = string.Concat(message, "Buzz ");
                while (Check_forBuzz >= 7)
                {
                    Check_forBuzz = Check_forBuzz / 7;
                    if (Check_forBuzz % 7 == 0)
                        message = string.Concat(message, "buzz ");
                }
             }

            // checking whether the given number contains 7
            while (Contains_Buzz > 0)
            {
                int temp = Contains_Buzz % 10;
                if (temp == 7)
                {
                    if (message.Contains("Buzz "))
                        message = string.Concat(message, "buzz ");
                    else
                        message = string.Concat(message, "Buzz ");
                }
                Contains_Buzz = Contains_Buzz / 10;
            }
            
            // if the number is not divisble by 5 and 7
            // also it does not contain 5 and 7
            // just return the given number
            if (string.IsNullOrEmpty(message))
                message = string.Concat(message, given_number);

            // trimming the trailing white space
            // and returning the output with adding '!' to get exact output format
            message = message.TrimEnd();
            return string.Concat(message, "!");
        }
    }
}
