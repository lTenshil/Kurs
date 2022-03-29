using System;
using System.Collections.Generic;

namespace Курсачъ
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }
        public decimal Price { get; set; }
        public string Parameter { get; set; }
        public string Manufacturer { get; set; }
        public DateTime DateOfManufacturer { get; set; }
        public int Guarantee_period { get; set; }
        public virtual ICollection<Sale> Sale { get; set; }

        public Product(int id, string name, string category, string subCategory, decimal price, string parameter, string manufacturer, DateTime dateOfManufacturer, int guarantee_period)
        {
            Id = id;
            Name = name;
            Category = category;
            SubCategory = subCategory;
            Price = price;
            Parameter = parameter;
            Manufacturer = manufacturer;
            DateOfManufacturer = dateOfManufacturer;
            Guarantee_period = guarantee_period;
        }

        public Product(string name, string category, string subCategory, decimal price, string parameter, string manufacturer, DateTime dateOfManufacturer, int guarantee_period)
        {
            Name = name;
            Category = category;
            SubCategory = subCategory;
            Price = price;
            Parameter = parameter;
            Manufacturer = manufacturer;
            DateOfManufacturer = dateOfManufacturer;
            Guarantee_period = guarantee_period;
        }

        public Product ()
        {

        }
    }
}
