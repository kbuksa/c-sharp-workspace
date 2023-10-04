using System;

class Program
{
    static void Main(string[] args)
    {
        // Declare some basic value type variables
        int i = 10;
        float f = 2.0f;
        decimal d = 10.0m;
        bool b = true;
        char c = 'c';

        // Declare a string - it's a collection of characters
        string str = "a string";

        // Declare an implicit variable
        var x = 10;
        var z = "Hello!";

        // TODO: Declare an array of values
        int[] vals = new int[5];
        string[] strs = {"one", "two", "three"};

        // TODO: Print the values using a Formatting String
        Console.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7}", i, c, b, str, f, d, x, z);

        // TODO: "null" means "no value"
        object obj = null;
        Console.WriteLine(obj);

        // TODO: Implicit conversion between types
        long bignum = i;

        // TODO: Explicit conversions
        float i_to_f = (float)i;
        int f_to_i = (int)f;

        Console.WriteLine("int to float: {0},\nfloat to int: {1}",i_to_f, f_to_i);

        // TODO: String Interpolation
        string name = "Alice";
        int age = 30;
        
        // embed expressions within string literals using 
        // string interpolation, denoted by the $ symbol
        string msg = $"Hello, {name}! You're {age} years old!";
        Console.WriteLine(msg);
    }
}
