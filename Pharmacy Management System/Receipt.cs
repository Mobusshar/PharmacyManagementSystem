using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management_System
{
    public class Receipt
    {

        public int ID { get; set ;  }

        public string P_name { get; set ; }

        public int quantity { get; set; }

        public double price { get; set; }

        public string Total {get  { return string.Format("{Ø}$", price * quantity); }  }


    }
}
