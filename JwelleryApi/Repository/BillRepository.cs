using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using JwelleryApi.Context;
using JwelleryApi.Models;
using Microsoft.AspNetCore.Mvc;
using Syncfusion.Drawing;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;

namespace JwelleryApi.Repository
{
    public class BillRepository : IBill
    {
        //private ApplicationDbContext _context;
        //public BillRepository(ApplicationDbContext context)
        //{
        //    _context = context;
        //}
        public GoldBill CalculateBill(GoldBill bill)
        {
            if(bill != null)
            {
                float price = bill.GoldPrice * bill.Weight;
                bill.TotalPrice = price - (price * bill.Discount) / 100;
            }
            return bill;
        }

        public FileStreamResult PrintBill(PrintBill Print)
        {
            PdfDocument document = new PdfDocument();
            PdfPage page = document.Pages.Add();
            PdfGraphics graphics = page.Graphics;
            PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 20);
            graphics.DrawString(Print.Html, font, PdfBrushes.Black, new PointF(0, 0));
            MemoryStream stream = new MemoryStream();

            document.Save(stream);
            stream.Position = 0;

            //Download the PDF document in the browser
            FileStreamResult fileStreamResult = new FileStreamResult(stream, "application/pdf");

            fileStreamResult.FileDownloadName = "Sample.pdf";

            return fileStreamResult;
        }

        public void PrintViaPaper()
        {
            throw new NotImplementedException();
        }
    }
}
