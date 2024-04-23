//The version 03 of Computer Project
using System;
using OOP_in_Csharp;
using Helperspace;
class Program
{
    public static void Main(string[] args)
        {
            List<Computer> net = new List<Computer>();

             //switching ON the server
            Console.WriteLine("\n\n------ starting server ------");
            Computer server = new Computer();
            server.BiosName = "SERVER";
            server.ON = true;
            server.IPAddress = "10.0.100.100";
            server.OS = "Linux";
            net.Add(server);
            List<string> ipaddresses = new List<string>();
            ipaddresses = server.addresses(10);
            Console.WriteLine("Server is ON ...");
        

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

            // shuting down computers
            Console.WriteLine("\n\n------ shuting down computers ------");
            Helper.ShutDownComp(net, "comp1");
            Helper.ShutDownComp(net, "comp3");
            Helper.ShowComputers(net);

        // pinging
            Console.WriteLine("\n\n------ pinging ------");
            Console.Write("Enter the IP address of a computer you want to ping to: ");
            string ip_to = Console.ReadLine();
            if (ip_to != null)
            {
                Helper.ping(ip_to, net);
            }

       }  // method Main()
    } // class Program




