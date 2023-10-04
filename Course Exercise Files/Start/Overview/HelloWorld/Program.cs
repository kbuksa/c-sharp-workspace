// Namespace containing fundamental types & 
// classes of .NET Framework libraries
using System;

// New class called Program
class Program {

    // Main method which outputs Hello World
    static void Main(string[] args){
        Console.WriteLine("Hello New World!");
        Console.WriteLine("What's your name?");
        #nullable disable
        string str = Console.ReadLine();
        #nullable restore
        Console.WriteLine("Hello there " + str + "!");
    }
}