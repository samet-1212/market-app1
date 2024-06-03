using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace samet_market_app.Models
{
    public class Inventory
    {
        public int InventoryId { get; set; }
        public string ItemName { get; set; }
        public int ItemPrice { get; set; }
        public int ItemStock { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }




    }

}
