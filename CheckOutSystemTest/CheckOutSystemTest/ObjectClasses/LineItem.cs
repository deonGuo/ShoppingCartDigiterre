using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOutSystemTest.ObjectClasses
{
    //the line item object of the shopping cart. A shopping cart contains a list of line items
    public class LineItem : IEquatable<LineItem>
    {
        public Product lineProduct { get; set; } //the product of the line item
        public int quantityLineProduct { get; set; }//quantity of the product chosen

        public LineItem(Product product, int quantity)
        {
            this.lineProduct = product;
            if (quantity > 0)
            {
                this.quantityLineProduct = quantity;
            }
            else
            {
                Console.WriteLine("quantity cannot be negative");
            }
        }

        public bool Equals(LineItem other)
        {
            //true if both the product and quantity are the same
            return (this.lineProduct.Equals(other.lineProduct) && (this.quantityLineProduct == other.quantityLineProduct));
        }

        public bool Equals(string productName, string quantity)
        {
            return (this.lineProduct.Name == productName.ToUpper().Trim()) && (this.quantityLineProduct.ToString() == quantity);
        }

        public int Subtotal()
        {
            return lineProduct.UnitPrice * quantityLineProduct;
        }

        public override string ToString()
        {
            return "[" + this.lineProduct.Name + "] @ " + this.lineProduct.UnitPrice + " * " + this.quantityLineProduct + " = " + this.Subtotal();
        }
    }
}
