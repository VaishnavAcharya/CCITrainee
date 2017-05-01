using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UsingJqueryDataTables.Models;

namespace UsingJqueryDataTables.ViewModel
{
    public class OrderDetailsViewModel

    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public float Discount { get; set; }

        public IList<Order_Detail> OrderDetails { get; set; }
    }
}