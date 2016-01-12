using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketMachine
{
    class Display
    {
        public void ShowText(string text)
        {
            Console.WriteLine(text);
        }

        public void ShowEstimatedExpireTime (int amount)
        {
            Console.WriteLine(System.DateTime.Now + new TimeSpan(amount, 0, 0));
        }
    }
}
