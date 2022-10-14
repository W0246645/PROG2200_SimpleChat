using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        }
    }
}
