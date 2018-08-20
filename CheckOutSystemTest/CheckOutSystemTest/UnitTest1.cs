using System;
using CheckOutSystemTest.ObjectClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CheckOutSystemTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PurchaseSingleAppleOrange()
        {
            ShoppingCart cart = new ShoppingCart();
            //retrieve the products from the catalogue
            Product apple = Catalogue.GetProductByName("apple");
            Product orange = Catalogue.GetProductByName("orange");
            cart.AddLineItem(new LineItem(apple, 1));
            cart.AddLineItem(new LineItem(orange, 1));
            Console.WriteLine(cart);
        }

        [TestMethod]
        public void PurchaseMultipleAppleOrange()
        {
            ShoppingCart cart = new ShoppingCart();
            Product apple = Catalogue.GetProductByName("apple");
            Product orange = Catalogue.GetProductByName("orange");
            cart.AddLineItem(new LineItem(apple, 2));
            cart.AddLineItem(new LineItem(orange, 10));
            Console.WriteLine(cart);
        }

        [TestMethod]
        public void PurchaseUnavailableProduct()
        {
            ShoppingCart cart = new ShoppingCart();
            Product apple = Catalogue.GetProductByName("apple");
            Product orange = Catalogue.GetProductByName("orange");
            Product banana = Catalogue.GetProductByName("banana");
            Product watermelon = Catalogue.GetProductByName("watermelon");
            cart.AddLineItem(new LineItem(banana, 2));
            cart.AddLineItem(new LineItem(orange, 10));
            cart.AddLineItem(new LineItem(watermelon, 1));
            Console.WriteLine(cart);
        }

        [TestMethod]
        public void RemoveFromCart()
        {
            ShoppingCart cart = new ShoppingCart();
            Product apple = Catalogue.GetProductByName("apple");
            Product orange = Catalogue.GetProductByName("orange");
            cart.AddLineItem(new LineItem(apple, 2));
            cart.AddLineItem(new LineItem(orange, 10));
            Console.WriteLine(cart);
            cart.RemoveLineItem(new LineItem(apple, 2));
            cart.RemoveLineItem(new LineItem(orange, 1));
            Console.WriteLine(cart);
        }

        [TestMethod]
        public void UpdateCart()
        {
            ShoppingCart cart = new ShoppingCart();
            Product apple = Catalogue.GetProductByName("apple");
            Product orange = Catalogue.GetProductByName("orange");
            cart.AddLineItem(new LineItem(apple, 2));
            cart.AddLineItem(new LineItem(orange, 10));
            Console.WriteLine(cart);
            cart.UpdateLineItem(new LineItem(apple,2), 20);
            Console.WriteLine(cart);
            cart.UpdateLineItem(new LineItem(orange, 1), 20);
            Console.WriteLine(cart);
        }
    }
}
