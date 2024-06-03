using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace samet_market_app.Models
{
    public class Sale
    {
        public int SaleId { get; set; }
        
        public int ProductPrice { get; set; }
        public int Quantity { get; set; }
        public int TotalPrice { get; set; }
        public DateTime SaleDate { get; set; }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public Product Product { get; set; }
    }

}
