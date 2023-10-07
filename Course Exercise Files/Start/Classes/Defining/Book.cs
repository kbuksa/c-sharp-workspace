using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Defining
{
    // classes have a name, unique within the namespace
    public class Book
    {
        // TODO: classes have member variables, or "fields" to hold data
        string _name, _author;
        int _pageCount;


        // TODO: classes have one or more constructors
        public Book(string name, string author, int pages) {
            _name = name;
            _author = author;
            _pageCount = pages;
        }


        // TODO: methods are used to operate on the class and data
        public string getDescription() {
            return $"{_name} by {_author}";
        }

    }
}
