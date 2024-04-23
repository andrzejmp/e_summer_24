using System;
using System.Collections.Generic;

namespace OOP_in_Csharp
{
    class Computer
    {
        private string _BIOSname;
        private string _ipadress;
        private string _OS;
        private bool _ON;
        private static int _counter = 0;
        public Computer(string bn, string ip, string os)
        {
            this._BIOSname = bn;
            this._ipadress = ip;
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

            public void StartComputer(string ip)
        {
            IPAddress = ip;
            ON = true;
        }

    }
}