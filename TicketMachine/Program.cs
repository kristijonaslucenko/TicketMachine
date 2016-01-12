using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            TicketMachine ticketMachine = new TicketMachine();
            
            ticketMachine.PutCreditCard("12345");
            ticketMachine.DKK1();
            ticketMachine.DKK5();
            ticketMachine.OK();



            Console.ReadLine();
        }
    }
}
