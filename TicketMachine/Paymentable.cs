using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketMachine
{
    interface Paymentable
    {
        bool Pay(int suma);
        void Cancel();
    }
}
