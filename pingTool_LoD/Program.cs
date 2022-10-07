using System;
using System.Net.NetworkInformation; 

namespace PingProto
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("1 - EU, 2 - HKT, 3 - EST");

            string input = Console.ReadLine();
            int selectedOption;
            if (int.TryParse(input, out selectedOption))
            {
                if (selectedOption == 1)
                {
                    try
                    {
                        Ping myPing = new Ping();
                        Console.WriteLine("Eu server:");
                        PingReply reply = myPing.Send("47.91.87.28", 1000);
                        if (reply != null)
                        {
                            Console.WriteLine("Status :  " + reply.Status + " \nTime : " + reply.RoundtripTime.ToString() + "ms");
                            //Console.WriteLine(reply.ToString());

                        }
                    }
                    catch
                    {
                        Console.WriteLine("ERROR: You have Some TIMEOUT issue");
                    }
                    Console.ReadKey();
                }

                else if (selectedOption == 2)
                {
                    try
                    {
                        Ping myPing = new Ping();
                        PingReply reply = myPing.Send("47.88.173.11", 1000);
                        if (reply != null)
                        {
                            Console.WriteLine("Status :  " + reply.Status + " \nTime : " + reply.RoundtripTime.ToString() + "ms");
                            

                        }
                    }
                    catch
                    {
                        Console.WriteLine("ERROR: You have Some TIMEOUT issue");
                    }
                    Console.ReadKey();
                }

                else if (selectedOption == 3)
                {
                    try
                    {
                        Ping myPing = new Ping();
                        PingReply reply = myPing.Send("43.135.190.56", 1000);
                        if (reply != null)
                        {
                            Console.WriteLine("Status :  " + reply.Status + " \nTime : " + reply.RoundtripTime.ToString() + "ms");
                            

                        }
                    }
                    catch
                    {
                        Console.WriteLine("ERROR: You have Some TIMEOUT issue");
                    }
                    Console.ReadKey();
                }
            }
        }
    }
}