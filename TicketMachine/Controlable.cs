using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketMachine
{
    interface Controlable
    {
        void DKK1();
        void DKK5();
        void DKK20();
        void PutCreditCard(string id);
        void PutCoin(int amount);
        void OK();
        void Cancel();
    }
}
