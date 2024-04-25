// C# writing and appending to text file

using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        
        string file = @"C:\labo\e_summer_24\oop\comp24b\log.txt";

        DateTime currentTime = DateTime.Now;
        Console.WriteLine("Current local time is: " + currentTime);
        //----------------------------------------------------------

        //string text = "Computer project - log\n";
        //File.WriteAllText(file, text);

        string text = currentTime + " 10.0.0.12 comp1 on \n";
        File.AppendAllText(file, text);
    
        text = currentTime + " 10.0.0.12 comp1 off\n\n";
        File.AppendAllText(file, text);



    }
}
