﻿using System;
using System.Text;

namespace DeveloperTests.Part1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var result = WriteFizzBuzz();
            Console.WriteLine(result);
        }

        public static string WriteFizzBuzz()
        {
            var sb = new StringBuilder();
            for (int i = 1; i <= 100; i++)
            {
                var threeRemainder = i % 3;
                var sixRemainder = i % 5;
                if (threeRemainder == 0)
                {
                    sb.Append("Fizz");
                }

                if (sixRemainder == 0)
                {
                    sb.Append("Buzz");
                }

                if (threeRemainder != 0 && sixRemainder != 0)
                {
                    sb.Append(i);
                }
            }
            
            return sb.ToString();
        }
    }
}
