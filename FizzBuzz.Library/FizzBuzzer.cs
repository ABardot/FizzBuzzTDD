﻿namespace FizzBuzz.Library
{
    public class FizzBuzzer
    {
        public static string GetValue(int input)
        {
            if (input == 3)
            {
                return "Fizz";
            }
           
            if (input == 5)
            {
              return "Buzz";
            }

            return input.ToString();
        }
    }
}