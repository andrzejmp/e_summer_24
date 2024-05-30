using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace OOP_in_Csharp
{
    public class Computer
    {
        private string _BIOSname;
        private string _ipadress;
        private string _OS;
        private bool _ON;
        private static int _counter = 0;
        public Computer(string bn, string os)
        {
            this._BIOSname = bn;
           // this._ipadress = ip;
            this._OS = os;
            this._ON = false;

            _counter++;
        }
        public Computer()
        {
            _counter++;
        }
        public static int getCompsNum()
        {
            return _counter;
        }
        //proprties
        public string BiosName
        {
            get { return this._BIOSname; }
            set { this._BIOSname = value; }
        }
        public string IPAddress
        {
            get { return this._ipadress; }
            set { this._ipadress = value; }
        }

        public string OS
        {
            get { return this._OS; }
            set { this._OS = value; }
        }

        public bool ON
        {
            get { return this._ON; }
            set { this._ON = value; }
        }
        public static string getNum()
        {
            Random random = new Random();
            int num;
            num = random.Next(1, 255);
            return num.ToString();
        }
        
        public virtual void StartComputer(string ip)
        {
            IPAddress = ip;

            string file = @"c:\labo\log.txt";
            DateTime currentTime = DateTime.Now;
            string text = currentTime + " " + this.IPAddress + " " + this.BiosName + "  on \n";
            File.AppendAllText(file, text);

            ON = true;
        }

        //public static void log()
       // {
            
       // }

    } // end computer

    public class Server : Computer
    {

        public Server(string bn, string os, string type) : base(bn, os)
        {
            this.Type = type;
        }

        public Server() { }

        protected string type;
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        //--------

        public List<string> addresses(int N)
        {
            List<string> dhcpAddresses = new List<string>();
            int count = 0;
            string piece = "";

            while (count < N)
            {
                piece = "10.0." + getNum() + "." + getNum();
                if (dhcpAddresses.Contains(piece) == false)
                {
                    dhcpAddresses.Add(piece);
                    count++;
                }
            }
            return dhcpAddresses;
        }


        //---------




        public override void StartComputer(string ip)
        {
            IPAddress = ip;

            string file = @"c:\labo\log.txt";
            DateTime currentTime = DateTime.Now;
            string text = currentTime + " " + IPAddress + " " + this.BiosName + "  on \n";
            File.AppendAllText(file, text);

            //ON = true;
        }

        //----------------
        public void ShutDownServer()
        {
            Console.WriteLine("The server id OFF");

            string yes;

            Console.Write("Do you want to switch off the server (yes/no)? ");
            yes = Console.ReadLine();
            if (yes == "yes")
            {
                ON = false;
                string file = @"c:\labo\log.txt";
                DateTime currentTime = DateTime.Now;
                string text = currentTime + " " + IPAddress + " " + this.BiosName + "  off \n";
                File.AppendAllText(file, text);
            }
        }

        //----------------

    }

}