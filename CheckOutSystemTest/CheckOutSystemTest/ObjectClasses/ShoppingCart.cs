 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOutSystemTest.ObjectClasses
{
    public class ShoppingCart
    {
        public List<LineItem> lineItems;

        public ShoppingCart()
        {
            lineItems = new List<LineItem>();
        }

        //add new line item to the shopping cart
        public void AddLineItem(LineItem newLineItem)
        {
            //only products in catalogue are allowed to be added to shopping cart
            if(Catalogue.IsProductInCatalogue(newLineItem.lineProduct) && newLineItem.quantityLineProduct > 0)
            {
                lineItems.Add(newLineItem);
            }
            else
            {
                Console.WriteLine("Item NOT added");
            }
        }

        public void RemoveLineItem(LineItem lineItemToRemove)
        {
            //LineItem implemented IEquatable interface hence remove will use the Equals() defined in LineItem class 
            if (lineItems.Remove(lineItemToRemove))
            {
                Console.WriteLine("line item with product [" + lineItemToRemove.lineProduct.Name + "] and quantity + [" + lineItemToRemove.quantityLineProduct + "] is removed");
            }
            else
            {
                Console.WriteLine("line item NOT not found");
            }
        }

        //update a specific lineItem's quantity.  Assume the product of the lineItem cannot be updated as common shopping cart practice
        public void UpdateLineItem(LineItem lineItemToUpdate, int newQuantity)
        {
            //get the index of the lineItem to update - Equals() defined in lineItem class
            //if no item found, FindIndex() returns -1
            int indexToUpdate = lineItems.FindIndex(lineItem => lineItem.Equals(lineItemToUpdate));

            //update the quantity of the lineItem if found
            if(indexToUpdate >= 0)
            {
                Console.WriteLine("Updating Line Item of product [" + lineItemToUpdate.lineProduct.Name + "] from [" + lineItemToUpdate.quantityLineProduct + "] to [" + newQuantity + "]");
                lineItems.ElementAt(indexToUpdate).quantityLineProduct = newQuantity;}
            else
            {
                Console.WriteLine("Not updated.  Line Item not found");
            }
        }

        public bool Contains(LineItem line)
        {
            if(line == null)
            {
                return false;
            }
            else{
                //LineItem implemented IEquatable interface
                return lineItems.Contains(line);
            }
        }

        public bool Contains(string productName, string quantity)
        {
            //loop through each lineItem in the cart, if found any line with same product name and quantity, match, return true
            foreach(LineItem line in lineItems)
            {
                if(line.Equals(productName, quantity))
                {
                    return true;
                }
            }
            return false;
        }

        public void EmptyCart()
        {
            lineItems.Clear();
        }

        //tally up all lines' subtotal
        public int Total()
        {
            int total = 0;
            foreach(LineItem lineItem in lineItems)
            {
                total += lineItem.Subtotal();
            }

            return total;
        }

        public override string ToString()
        {
            string result = "Shopping Cart Content: \r\n";
            for(int i=0; i<lineItems.Count; i++)
            {
                result += "Line " + (i+1) + ":   " + lineItems[i] + "\r\n";
            }
           
            result += "\r\nTotal: " + this.Total();
            return result;
        }

    }
}
