using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JwelleryApi.Models
{
    public class GoldBill
    {
        public float GoldPrice { get; set; }
        public float Weight { get; set; }
        public float Discount { get; set; }
        public float TotalPrice { get; set; }
        
    }

    public class PrintBill {
       public  string Html { get; set; }
    }

}
