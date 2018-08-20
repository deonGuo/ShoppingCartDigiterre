using CheckOutSystemTest.ObjectClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace CheckOutSystemTest.stepDefinition
{
    [Binding]
    public sealed class AddToShoppingCart
    {
        private readonly ShoppingCart cart;

        public AddToShoppingCart(ShoppingCart cart)
        {
            this.cart = cart;
        }
        #region Given
        [Given(@"I have an empty shopping cart")]
        public void GivenIHaveAnEmptyShoppingCart()
        {
            cart.EmptyCart();
            //cart = new ShoppingCart();
        }
        #endregion

        #region When
        [When(@"I add (.*) with quantity (.*) to the cart")]
        [Given(@"I add (.*) with quantity (.*) to the cart")]
        public void WhenIAddWithQuantityToTheCart(string productName, string quantity)
        {
            try
            {
                if(productName == null)
                {
                    throw new ArgumentNullException("productName or quantity");
                }
                Product product = Catalogue.GetProductByName(productName.ToUpper().Trim());
                int intQuantity = Int32.Parse(quantity);
                cart.AddLineItem(new LineItem(product, intQuantity));
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        [Given(@"the cart has an item line of (.*) with quantity (.*)")]
        public void GivenTheCartHasAnItemLineOfWithQuantity(string product, string quantity)
        {
            WhenIAddWithQuantityToTheCart(product, quantity);
            Assert.IsTrue(cart.Contains(product.ToUpper().Trim(), quantity));
        }
        #endregion

        #region Then
        [Then(@"the cart contains a line item (.*) with quantity (.*)")]
        public void ThenTheCartContainALineItemWithQuantity(string productName, string quantity)
        {
            try {
                Assert.IsTrue(cart.Contains(productName.ToUpper().Trim(), quantity));
            }
            catch(FormatException e)
            {
                Assert.IsTrue(false); //fail the test when exception is caught
                Console.WriteLine(e.ToString());
            }
        }

        [Then(@"the cart does not contain a line item (.*) with quantity (.*)")]
        public void ThenTheCartDoesNotContainALineItemWithQuantity(string productName, string quantity)
        {
            try { 
                Assert.IsFalse(cart.Contains(productName.ToUpper().Trim(), quantity));
            }catch(FormatException e)
            {
                Assert.IsTrue(false);
                Console.WriteLine(e.ToString());
            }
        }

        [Then(@"the total cost is (.*) pence")]
        public void ThenTheTotalCostIsPence(int total)
        {
            try
            {
                Assert.AreEqual(total, cart.Total());
            }
            catch (FormatException e)
            {
                Assert.IsTrue(false);
                Console.WriteLine(e.ToString());
            }

        }

        #endregion

    }
}
