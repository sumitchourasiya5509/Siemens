using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JwelleryApi.Models;
using JwelleryApi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JwelleryApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BillsController : ControllerBase
    {
        private IBill _bill;
        public BillsController(IBill bill)
        {
            _bill = bill;
        }
        [HttpGet]
        public IActionResult Get([FromBody] GoldBill bill)
        {
            bill = _bill.CalculateBill(bill);
            return Ok(bill);
        }

        
        [HttpGet]
        public IActionResult PrintBill([FromQuery] PrintBill BillHtml)
        {
            FileStreamResult result = _bill.PrintBill(BillHtml);
            return Ok(result);
        }

        [HttpGet]
        public IActionResult PrintViaPaper()
        {
            _bill.PrintViaPaper();
            return BadRequest();
        }
    }
}