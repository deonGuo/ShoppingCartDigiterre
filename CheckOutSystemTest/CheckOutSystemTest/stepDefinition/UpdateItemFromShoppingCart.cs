using CheckOutSystemTest.ObjectClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace CheckOutSystemTest.stepDefinition
{
    [Binding]
    public sealed class UpdateItemFromShoppingCart
    {
        private readonly ShoppingCart cart;
        public UpdateItemFromShoppingCart(ShoppingCart cart)
        {
            this.cart = cart;
        }

        [When(@"I update item line of (.*) with quantity (.*) to quantity (.*) from the cart")]
        public void WhenIUpdateItemLineOfProductWithQuantityToQuantityFromTheCart(string productName, string quantity, string updatedQuantity)
        {
            try
            {
                if (productName == null)
                {
                    throw new ArgumentNullException("productName or quantity");
                }
                Product product = Catalogue.GetProductByName(productName.ToUpper().Trim());
                int intQuantity = Int32.Parse(quantity);
                int intUpdatedQuantity = Int32.Parse(updatedQuantity);
                cart.UpdateLineItem(new LineItem(product, intQuantity), intUpdatedQuantity);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.ToString());
            }
        }

    }
}
