﻿using System;

namespace ConditionalOps
{
    class Program
    {
        static void Main(string[] args)
        {
            int theVal = 55;

            // TODO: The switch statement
            switch (theVal) {
                case 50:
                    Console.WriteLine("theVal is 50");
                    break;
                case 51:
                    Console.WriteLine("theVal is 51");
                    break;
                case 52:
                case 53:
                case 54:
                    Console.WriteLine("theVal between 52-54");
                    break;
                default:
                Console.WriteLine("theVal something else"); 
                break;               
            }
        }
    }
}
