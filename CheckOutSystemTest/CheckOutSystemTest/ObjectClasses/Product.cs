using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOutSystemTest
{
    public class Product:IEquatable<Product>
    {
        public string Name { get; set; }
        public int UnitPrice { get; set; }  //count price in cent, i.e.: $1.25 = 125c

        public Product(string name, int unitPrice)
        {
            if (!string.IsNullOrEmpty(name))
            {
                this.Name = name.ToUpper().Trim();
                this.UnitPrice = unitPrice;
            }
            else
            {
                throw new ArgumentNullException("name");
            }
        }

        public bool Equals(Product newProduct)
        {
            //if the product names are identical then they're considered equal/duplicate
            return (newProduct != null) && (newProduct.Name == this.Name);
        }
    }
}
