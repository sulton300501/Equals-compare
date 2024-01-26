using System;


namespace ConsoleApp69;






class Program
{
     
    static void Main(string[] args)
    {
        var a = new Person("John");
        var b = new Person("John");
        

        bool equal = a.Name.Equals(b.Name);
        Console.WriteLine(equal);

    }
}


