using OOP_in_Csharp;
using System;
using System.Collections.Generic;
namespace Helperspace
{
    public class Helper
    {

        internal static void ShowComputers(List<Computer> network)
        {
            foreach (Computer comp in network)
            {
                string is_on = "";
                if (comp.ON) { is_on = "ON"; }
                Console.WriteLine("{0} {1} {2} {3}", comp.BiosName, comp.IPAddress, comp.ON, is_on );
            }
            Console.WriteLine("We have {0} computers!!!!", Computer.getCompsNum());
        } // end of ShowCompters method


        internal static void ShutDownComp(List<Computer> network, string compName)
        {

            for (int i = 0; i < network.Count; i++)
            {
                if (network[i].BiosName == compName)
                {
                    string file = @"c:\labo\log.txt";
                    DateTime currentTime = DateTime.Now;
                    string text = currentTime + "  " + network[i].IPAddress + " " + network[i].BiosName + "  off \n";
                    File.AppendAllText(file, text);
                    network[i].ON = false;
                    network.RemoveAt(i);
                }

            }
        } // end of ShutDownComp method

        internal static void ping(string ip_to, List<Computer> network)
        {
            Random random = new Random();
            int min = 10000;
            int max = 0;
            int time = 0;
            double avg = 0;

            bool found = false;
            for (int i = 0; i < network.Count; i++)
            {
                if (ip_to == network[i].IPAddress)
                {
                    found = true;
                    break;
                }
            }
            if (found)
            {
                Console.WriteLine("Pinging {0} with 32 bytes of data:", ip_to);
                for (int i = 0; i < 4; i++)
                {
                    time = random.Next(1, 50);
                    if (time > max) { max = time; }
                    if (time < min) { min = time; }
                    avg += time;
                    Console.WriteLine("Reply from {0}: bytes=32 time={1}ms TTL=55", ip_to, time);
                }

                Console.WriteLine("Ping statistics for {0}", ip_to);
                Console.WriteLine("Minimum = {0}ms Maximum = {1}ms Average = {2}ms", min, max, Math.Round(avg / 4, 0));
            }
            else
            {
                Console.WriteLine("Pinging {0} with 32 bytes of data:", ip_to);
            }
        }  //end of ping

        internal static void displayMenu()
        {
            Console.WriteLine("\n\n----Menu-----");
            Console.WriteLine("2. Start server");
            Console.WriteLine("2. Start computers");
            Console.WriteLine("3. Shut down computers");
            Console.WriteLine("4. Ping tot computers");
            Console.WriteLine("0. Quit");
            Console.Write("\nChoose the option:  ");
        }
        
}
}
