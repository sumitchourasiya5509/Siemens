using JwelleryApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JwelleryApi.Repository
{
   public interface IBill
    {
        GoldBill CalculateBill(GoldBill bill);
        FileStreamResult PrintBill(PrintBill Print);
        void PrintViaPaper();
    }
}
