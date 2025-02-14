using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDeskApp
{
    public partial class DeskQuote
    {
        public string customerName { get; set; }
        public string orderDate { get; set; }
        public Desk desk { get; set; }
        public int shippingDays { get; set; }
        public double price { get; set; }
        public DeskQuote()
        {
            customerName = string.Empty;
            var desk = new Desk();
        }
    }
}
