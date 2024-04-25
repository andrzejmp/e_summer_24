//The version 03 of Computer Project
using System;
using OOP_in_Csharp;
using Helperspace;
using System.Net;
class Program
{
    public static void Main(string[] args)
        {
        string file = @"c:\labo\log.txt";

        DateTime currentTime = DateTime.Now;
        //Console.WriteLine("Current local time is: " + currentTime);
        //string text = "Computer project - log\n";
        //File.WriteAllText(file, text);


        List<Computer> net = new List<Computer>();
            List<string> ipaddresses = new List<string>();

            bool end = false;
            string choice = "";
            do
             { 
             Helper.displayMenu();
             choice = Console.ReadLine();
             Console.WriteLine("------------------------\n  ");
             Console.Clear();

            if (choice == "1")
            {
                //switching ON the server

                Console.WriteLine("\n\n------ starting server ------");
                Computer server = new Computer();
                server.BiosName = "SERVER";
                server.ON = true;
                server.IPAddress = "10.0.100.100";
                server.OS = "Linux";
                net.Add(server);
                ipaddresses = server.addresses(10);
                Console.WriteLine("Server is ON ...");
             }

            if (choice == "2")
            {
            //switching ON 5 computers
            Console.WriteLine("\n\n------ starting computers in the network------");
            const int numComps = 5;
            for (int i = 1; i < numComps; i++)
            {
                Computer comp = new Computer("comp" + i.ToString(), "", "Win10");
                net.Add(comp);
                int last = ipaddresses.Count - 1;
                string ip = ipaddresses[last];
                ipaddresses.RemoveAt(last);
                net[i].StartComputer(ip);
            }
            Helper.ShowComputers(net);
            }


            if (choice == "3")
            {
            // shuting down computers
            Console.WriteLine("\n\n------ shuting down computers ------");
            Helper.ShutDownComp(net, "comp1");
            Helper.ShutDownComp(net, "comp3");
            Helper.ShowComputers(net);
            }


            if (choice == "4")
            {
            // pinging
            Console.WriteLine("\n\n------ pinging ------");
            Console.Write("Enter the IP address of a computer you want to ping to: ");
            string ip_to = Console.ReadLine();
            if (ip_to != null)
            {
                Helper.ping(ip_to, net);
            }

            }

            if (choice == "0")
            {
                end = true;
            }
          
            
        } while (!end);
    }  // method Main()
    } // class Program




