using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLSERVER
{
    class OrderDetail
    {
        public int PID { get; set; }
        public int Qty { get; set; }
        public double Price { get; set; }
        public OrderDetail()
        {
                
        }
        public OrderDetail(int pID, int qty, double price)
        {
            PID = pID;
            Qty = qty;
            Price = price;
        }
    }
}
