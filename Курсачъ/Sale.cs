using System;

namespace Курсачъ
{
    public class Sale
    {
        public int SaleId { get; set; }
        public int Product_Id { get; set; }
        public int EmployeeId { get; set; }
        public int Quantity { get; set; }
        public DateTime DateOfOrder { get; set; }
        public decimal Cost { get; set; }

        public virtual Product Product { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
