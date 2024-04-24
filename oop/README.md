# The Computer Project

Project Computer will present different features of OOP in C#. Some usage of LINQ will be shown.
The whole project consists of free files:
1. Computers.cs
2. Helper.cs
3. Program.cs



## Class Computer
### Method StartComputer()

```csharp {.line-numbers}
public void StartComputer(string ip)
{
    IPAddress = ip;
    ON = true;
}
```
The method StartComputer(string ip) assigns an IP addres of a computer that is switched on and assigns the boolean values true to the attribute ON.

### Method addresses()

```csharp
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
```