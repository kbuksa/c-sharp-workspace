using System;

namespace Comments
{
    class Program
    {
        /// XML Comments are used to help provide documentation
        /// They start with triple-slashes and have a special syntax
        /// <summary>
        /// This is main sample app function
        /// </summary>
        /// <param name="args"> Array of str args from cmd line </param>
        /// <returns>
        /// No return values
        /// </returns>
        
        static void Main(string[] args)
        {
            // Single line comments 2 slashes
            // Can have multiple of these
            Console.WriteLine("Hello World!");

            /*multiple
            line
            commments
            wow
            so
            many
            lines */
            Console.WriteLine("Hello New World!");

        }
    }
}
