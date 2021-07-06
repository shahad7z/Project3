using System;
using System.Collections.Generic;

namespace test.Net.Models
{
    public class order
    {
        public int orderID { get; set; }

        public DateTime orderDate { get; set; } = DateTime.Now;

        public int NumperOfItem { get; set; }

        public int orderPrice { get; set; }

        public customer customer { get; set; }

        public Nullable<int> customerID { get; set; }

        public Nullable<int> productId { get; set; }

        public product product { get; set; }
    }
}
