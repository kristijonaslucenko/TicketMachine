using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketMachine
{
    class CashPayment : Paymentable
    {
        public bool Pay(int suma)
        {
            //throw new NotImplementedException();
            return true;
        }

        public void Cancel()
        {
            //throw new NotImplementedException();
        }
    }
}
