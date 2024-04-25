using System;
class Program
{
    public static void Main(string[] args)
        {
            bool end = false;
            string choice = "";
            do
            {   Console.Clear();
                Console.WriteLine("1. Start server");
                Console.WriteLine("0. Quit");
                 Console.WriteLine("\n-----------------  ");
                Console.WriteLine("Choose the option:  ");
                choice = Console.ReadLine();
                if(choice == "0") 
                {
                    end = true;
                }
            }
            while (!end);
            

       }  // method Main()
    } // class Program




