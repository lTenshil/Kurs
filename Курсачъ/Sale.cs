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

        public Sale(int saleId, int product_Id, int employeeId, int quantity, DateTime dateOfOrder, decimal cost)
        {
            SaleId = saleId;
            Product_Id = product_Id;
            EmployeeId = employeeId;
            Quantity = quantity;
            DateOfOrder = dateOfOrder;
            Cost = cost;
        }

        public Sale(int product_Id, int employeeId, int quantity, DateTime dateOfOrder)
        {
            Product_Id = product_Id;
            EmployeeId = employeeId;
            Quantity = quantity;
            DateOfOrder = dateOfOrder;
        }

        public Sale(int product_Id, int employeeId, int quantity, DateTime dateOfOrder, decimal cost) : this(product_Id, employeeId, quantity, dateOfOrder)
        {
            Cost = cost;
        }

        public Sale()
        {

        }
    }
}
