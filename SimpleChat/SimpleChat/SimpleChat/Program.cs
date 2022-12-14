using ChatLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleChat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ------------------------ First Phase -------------------------
            /*
            //Part 1
            //1.Run as Client vs Server
            Console.WriteLine("Listening for messages");
            //2.User input mode: when user press "I" key.            
            var userKey = Console.ReadKey();
            //3.Display incoming message
            //4.Allow for input
            //5.Let the user quit
            Console.WriteLine($"You typed {userKey.Key}");
            Console.Beep();
            */

            // ------------------------ Second Phase -------------------------
            /*
            while (true)
            {
                //1.Run as Client vs Server
                Console.WriteLine("Listening for messages");
                //2.User input mode: when user press "I" key.            
                var userKey = Console.ReadKey();
                //3.Display incoming message
                //4.Allow for input
                //5.Let the user quit
                Console.WriteLine($"You typed {userKey.Key}");
                Console.Beep();
            }
            */

            // ------------------------ Third Phase -------------------------
            /*
            while (true)
            {
                //1.Run as Client vs Server
                Console.WriteLine("Listening for messages");
                if (Console.KeyAvailable)
                {
                    //2.User input mode: when user press "I" key.            
                    var userKey = Console.ReadKey();
                    //3.Display incoming message
                    //4.Allow for input
                    //5.Let the user quit
                    Console.WriteLine($"\nYou typed {userKey.Key}");
                    Console.Beep();
                    Thread.Sleep(500);
                }
            }
            */

            // ------------------------ Fourth Phase -------------------------
            /*
            while (true)
            {
                //1.Run as Client vs Server
                Console.WriteLine("Listening for messages");
                if (Console.KeyAvailable)
                {
                    //2.User input mode: when user press "I" key.            
                    var userKey = Console.ReadKey();
                    if (userKey.Key == ConsoleKey.I)
                    {
                        Console.Write("'I' is PRESSED >>"); //insertion mode
                        Console.Beep();
                        Thread.Sleep(500);
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine($"\nYou typed {userKey.Key}");
                        Console.Beep();
                        Thread.Sleep(500);
                    }
                }
            }
            */

            // ------------------------ Fifth Phase -------------------------
            /*
            if (args.Contains("-server"))
            {
                Console.WriteLine("Server");
            } else
            {
                Console.WriteLine("Client");
            }
            
            while (true)
            {
                //1.Run as Client vs Server
                Console.WriteLine("Listening for messages");
                if (Console.KeyAvailable)
                {
                    //2.User input mode: when user press "I" key.            
                    var userKey = Console.ReadKey();
                    if (userKey.Key == ConsoleKey.I)
                    {
                        Console.Write("'I' is PRESSED >>"); //insertion mode
                        Console.Beep();
                        Thread.Sleep(500);
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine($"\nYou typed {userKey.Key}");
                        Console.Beep();
                        Thread.Sleep(500);
                    }
                }
            }
            */

            // ------------------------ Sixth Phase -------------------------
            if (args.Contains("-server"))
            {
                Console.WriteLine("Server");
                var server = new Server();
            }
            else
            {
                Console.WriteLine("Client");
                var client = new Client();
            }

            while (true)
            {
                //1.Run as Client vs Server
                Console.WriteLine("Listening for messages");
                if (Console.KeyAvailable)
                {
                    //2.User input mode: when user press "I" key.            
                    var userKey = Console.ReadKey();
                    if (userKey.Key == ConsoleKey.Escape)
                    {
                        Console.WriteLine("Goodbye!");
                        break;
                    }
                    else if (userKey.Key == ConsoleKey.I)
                    {
                        Console.Write("'I' is PRESSED >>"); //insertion mode
                        Console.Beep();
                        Thread.Sleep(500);
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine($"\nYou typed {userKey.Key}");
                        Console.Beep();
                        Thread.Sleep(500);
                    }
                }
            }
        }
    }
}
