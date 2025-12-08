using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace LESSON1_1
{
    internal class Variables
    {
        // these are the variables used from example 6 up to example 8
        public Double amount_paid;
        public Double price;
        public Double cash_given;
        public Double change;
        public Double qty_total = 0;
        public Double discount_totalgiven = 0;
        public Double discounted_total = 0;
        public Double discount_amt;
        public Double discounted_amt;
        public Double total_amountPaid;
        public Int32 quantity;
    }
}
