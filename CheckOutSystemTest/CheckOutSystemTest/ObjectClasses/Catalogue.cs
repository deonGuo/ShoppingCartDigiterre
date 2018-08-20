using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOutSystemTest
{
    //The object that holds all available products.  Currently only apple and orange
    //only products available in the catalogue can be added to shopping cart, i.e.: apple and orange
    //methods to add or remove products to catalogue
    public static class Catalogue
    {
        public static readonly List<Product> products = new List<Product>()
        {
            new Product("ORANGE", 25),
            new Product("APPLE", 60)
        };

        public static void AddProduct(Product newProduct)
        {
            //check if the product is null
            if(newProduct == null)
            {
                Console.WriteLine("New Product can NOT be null!");
                return;
            }
            //check if the new product to be added exists already - we dont want to duplicate item in the catalogue - assume this is a business rule
            //if (products.Exists(existingProduct => existingProduct.Name.Equals(newProduct.Name)))
            if (IsProductInCatalogue(newProduct))
            {
                Console.WriteLine("Can NOT add [" + newProduct.Name + "] - already exists!");
            } else {
                products.Add(newProduct);
                Console.WriteLine("New Product [" + newProduct.Name + "] added with unit price [" + newProduct.UnitPrice + "] cents.");
            }
        }

        public static void RemoveProduct(Product offShelfProduct)
        {
            //check if the product is null
            if (offShelfProduct == null)
            {
                Console.WriteLine("New Product can NOT be null!");
                return;
            }
            if (products.Remove(offShelfProduct))
            {
                Console.WriteLine("Product [" + offShelfProduct.Name + "] removed from Catalogue");
            }
            else
            {
                Console.WriteLine("Product [" + offShelfProduct.Name + "] not found in Catalogue");
            }
        }

        //check if the product is on the catalogue
        public static bool IsProductInCatalogue(Product productToCheck)
        {
            //if the product to check in the catalogue is null then fail straight away
            if (productToCheck == null)
            {
                return false;
            }
            return products.Exists(existingProduct => existingProduct.Name.Equals(productToCheck.Name));
        }

        public static Product GetProductByName(string productName)
        {
            if(productName == null)
            {
                throw new ArgumentNullException("productName");
            }
            //look for the product by name
            Product productFound = products.Find(product => product.Name == productName.ToUpper().Trim());
            //if the product is not found, throw exception
            if ( productFound == null)
            {
                Console.WriteLine("Product [" + productName + "] NOT available from the catalogue.");
            }
            return productFound;
        }
    }
}
