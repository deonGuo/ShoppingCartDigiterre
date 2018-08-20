using CheckOutSystemTest.ObjectClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace CheckOutSystemTest.stepDefinition
{
    [Binding]
    public sealed class RemoveItemFromShoppingCart
    {
        private readonly ShoppingCart cart;
        public RemoveItemFromShoppingCart(ShoppingCart cart)
        {
            this.cart = cart;
        }

        #region Given


        #endregion

        #region When
        [When(@"I display cart content")]
        public void WhenIDisplayCartContent()
        {
            Console.WriteLine(cart.ToString());
        }

        [When(@"I remove item line of (.*) with quantity (.*) from the cart")]
        public void WhenIRemoveItemLineOfWithQuantityFromTheCart(string productName, string quantity)
        {
            try
            {
                if (productName == null)
                {
                    throw new ArgumentNullException("product or quantity");
                }
                Product product = Catalogue.GetProductByName(productName.ToUpper().Trim());
                int intQuantity = Int32.Parse(quantity);
                cart.RemoveLineItem(new LineItem(product, intQuantity));
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine(cart);
        }

        #endregion

        #region Then
        #endregion


    }
}
