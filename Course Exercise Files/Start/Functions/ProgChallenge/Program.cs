// C# code​​​​​​‌​‌​​‌​‌​‌​‌‌​​​​‌​‌​​‌‌​ below
using System;
using System.Text;

// Write your answer here, and then test your code.

public class Answer {

    // Determine whether a string is a Palindrome
    public static bool IsPalindrome(string thestr) {
        // Your code goes here.
        thestr = thestr.ToUpper();
        StringBuilder text = new StringBuilder();
        StringBuilder reversed = new StringBuilder();
        foreach (char c in thestr) {
            if (!Char.IsPunctuation(c) && !Char.IsWhiteSpace(c)) {
                text.Append(c);
            }
        }
        for (int i=0; i<text.Length; i++) {
            reversed.Append(text[text.Length - i - 1]);
        }
        Console.WriteLine($"text: {text.ToString()}, reverse: {reversed.ToString()}");
        return text.ToString() == reversed.ToString();
    }

    public static void Main(string[] args) {
        // This is how your code will be called.
        // You can edit this code to try different testing cases.
        string[] teststrings = { "Hello World!", "Race car!", "Rotor", "More cowbell!", "Madam, I'm Adam." };
        int palcount = 0;
        foreach (string str in teststrings) {
            bool learnerResult = IsPalindrome(str);
            if (learnerResult)
                palcount++;
        }
        Console.WriteLine(palcount);
    }
}