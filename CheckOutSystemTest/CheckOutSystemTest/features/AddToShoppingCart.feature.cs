﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.3.2.0
//      SpecFlow Generator Version:2.3.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace CheckOutSystemTest.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.2.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("Add products to shopping cart", Description="\tIn order to purchase products\r\n\tAs a customer\r\n\tI want to add products to my sho" +
        "pping cart", SourceFile="features\\AddToShoppingCart.feature", SourceLine=0)]
    public partial class AddProductsToShoppingCartFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "AddToShoppingCart.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Add products to shopping cart", "\tIn order to purchase products\r\n\tAs a customer\r\n\tI want to add products to my sho" +
                    "pping cart", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 6
#line 7
testRunner.Given("I have an empty shopping cart", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        public virtual void AddValidProductsToTheCart(string quantity, string product, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "positive"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add Valid Products To the Cart", @__tags);
#line 10
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 11
 testRunner.When(string.Format("I add {0} with quantity {1} to the cart", product, quantity), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 12
 testRunner.Then(string.Format("the cart contains a line item {0} with quantity {1}", product, quantity), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Add Valid Products To the Cart, Variant 0", new string[] {
                "positive"}, SourceLine=14)]
        public virtual void AddValidProductsToTheCart_Variant0()
        {
#line 10
this.AddValidProductsToTheCart("1", "apple", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Add Valid Products To the Cart, Variant 1", new string[] {
                "positive"}, SourceLine=14)]
        public virtual void AddValidProductsToTheCart_Variant1()
        {
#line 10
this.AddValidProductsToTheCart("1", "orange", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Add Valid Products To the Cart, Variant 2", new string[] {
                "positive"}, SourceLine=14)]
        public virtual void AddValidProductsToTheCart_Variant2()
        {
#line 10
this.AddValidProductsToTheCart("2", "apple", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Add Valid Products To the Cart, Variant 3", new string[] {
                "positive"}, SourceLine=14)]
        public virtual void AddValidProductsToTheCart_Variant3()
        {
#line 10
this.AddValidProductsToTheCart("1000", "orange", ((string[])(null)));
#line hidden
        }
        
        public virtual void AddValidProductsToTheCartAndCalculateTotal(string quantity, string product, string total, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "positive"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add Valid Products To the Cart and calculate Total", @__tags);
#line 22
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 23
 testRunner.When(string.Format("I add {0} with quantity {1} to the cart", product, quantity), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 24
 testRunner.Then(string.Format("the total cost is {0} pence", total), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Add Valid Products To the Cart and calculate Total, Variant 0", new string[] {
                "positive"}, SourceLine=26)]
        public virtual void AddValidProductsToTheCartAndCalculateTotal_Variant0()
        {
#line 22
this.AddValidProductsToTheCartAndCalculateTotal("1", "apple", "60", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Add Valid Products To the Cart and calculate Total, Variant 1", new string[] {
                "positive"}, SourceLine=26)]
        public virtual void AddValidProductsToTheCartAndCalculateTotal_Variant1()
        {
#line 22
this.AddValidProductsToTheCartAndCalculateTotal("1", "orange", "25", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Add Valid Products To the Cart and calculate Total, Variant 2", new string[] {
                "positive"}, SourceLine=26)]
        public virtual void AddValidProductsToTheCartAndCalculateTotal_Variant2()
        {
#line 22
this.AddValidProductsToTheCartAndCalculateTotal("2", "apple", "120", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Add Valid Products To the Cart and calculate Total, Variant 3", new string[] {
                "positive"}, SourceLine=26)]
        public virtual void AddValidProductsToTheCartAndCalculateTotal_Variant3()
        {
#line 22
this.AddValidProductsToTheCartAndCalculateTotal("1000", "orange", "25000", ((string[])(null)));
#line hidden
        }
        
        public virtual void AddInvalidQuantityOfProductsToTheCart(string quantity, string product, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "negative"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add invalid quantity of products to the cart", @__tags);
#line 35
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 36
 testRunner.When(string.Format("I add {0} with quantity {1} to the cart", product, quantity), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 37
 testRunner.Then(string.Format("the cart does not contain a line item {0} with quantity {1}", product, quantity), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Add invalid quantity of products to the cart, 0", new string[] {
                "negative"}, SourceLine=39)]
        public virtual void AddInvalidQuantityOfProductsToTheCart_0()
        {
#line 35
this.AddInvalidQuantityOfProductsToTheCart("0", "apple", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Add invalid quantity of products to the cart, -1", new string[] {
                "negative"}, SourceLine=39)]
        public virtual void AddInvalidQuantityOfProductsToTheCart_1()
        {
#line 35
this.AddInvalidQuantityOfProductsToTheCart("-1", "orange", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Add invalid quantity of products to the cart, 0.5", new string[] {
                "negative"}, SourceLine=39)]
        public virtual void AddInvalidQuantityOfProductsToTheCart_0_5()
        {
#line 35
this.AddInvalidQuantityOfProductsToTheCart("0.5", "apple", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Add invalid quantity of products to the cart, 10.5", new string[] {
                "negative"}, SourceLine=39)]
        public virtual void AddInvalidQuantityOfProductsToTheCart_10_5()
        {
#line 35
this.AddInvalidQuantityOfProductsToTheCart("10.5", "orange", ((string[])(null)));
#line hidden
        }
        
        public virtual void AddInvalidProductsToTheCartAndCheckValidProductsAreAdded(string quantity, string product, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "negative"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add invalid products to the cart and check valid products are added", @__tags);
#line 48
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 49
 testRunner.When(string.Format("I add {0} with quantity {1} to the cart", product, quantity), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 50
 testRunner.Then(string.Format("the cart does not contain a line item {0} with quantity {1}", product, quantity), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Add invalid products to the cart and check valid products are added, 1", new string[] {
                "negative"}, SourceLine=52)]
        public virtual void AddInvalidProductsToTheCartAndCheckValidProductsAreAdded_1()
        {
#line 48
this.AddInvalidProductsToTheCartAndCheckValidProductsAreAdded("1", "banana", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Add invalid products to the cart and check valid products are added, 2", new string[] {
                "negative"}, SourceLine=52)]
        public virtual void AddInvalidProductsToTheCartAndCheckValidProductsAreAdded_2()
        {
#line 48
this.AddInvalidProductsToTheCartAndCheckValidProductsAreAdded("2", "watermelon", ((string[])(null)));
#line hidden
        }
        
        public virtual void AddInvalidProductsToTheCartAndCalculateTotal(string quantity, string product, string total, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "negative"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add invalid products to the cart and calculate total", @__tags);
#line 59
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 60
 testRunner.When(string.Format("I add {0} with quantity {1} to the cart", product, quantity), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 61
 testRunner.Then(string.Format("the total cost is {0} pence", total), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Add invalid products to the cart and calculate total, 1", new string[] {
                "negative"}, SourceLine=63)]
        public virtual void AddInvalidProductsToTheCartAndCalculateTotal_1()
        {
#line 59
this.AddInvalidProductsToTheCartAndCalculateTotal("1", "banana", "0", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Add invalid products to the cart and calculate total, 2", new string[] {
                "negative"}, SourceLine=63)]
        public virtual void AddInvalidProductsToTheCartAndCalculateTotal_2()
        {
#line 59
this.AddInvalidProductsToTheCartAndCalculateTotal("2", "watermelon", "0", ((string[])(null)));
#line hidden
        }
        
        public virtual void AddValidProductsMultipleTimesToTheCartAndCheckValidProductsAreAdded(string product1, string quantity1, string product2, string quantity2, string product3, string quantity3, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "positive"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add valid products multiple times to the cart and check valid products are added", @__tags);
#line 69
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 70
 testRunner.When(string.Format("I add {0} with quantity {1} to the cart", product1, quantity1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 71
 testRunner.And(string.Format("I add {0} with quantity {1} to the cart", product2, quantity2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 72
 testRunner.And(string.Format("I add {0} with quantity {1} to the cart", product3, quantity3), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 73
 testRunner.Then(string.Format("the cart contains a line item {0} with quantity {1}", product1, quantity1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 74
 testRunner.And(string.Format("the cart contains a line item {0} with quantity {1}", product2, quantity2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 75
 testRunner.And(string.Format("the cart contains a line item {0} with quantity {1}", product3, quantity3), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Add valid products multiple times to the cart and check valid products are added," +
            " Variant 0", new string[] {
                "positive"}, SourceLine=77)]
        public virtual void AddValidProductsMultipleTimesToTheCartAndCheckValidProductsAreAdded_Variant0()
        {
#line 69
this.AddValidProductsMultipleTimesToTheCartAndCheckValidProductsAreAdded("orange", "10", "apple", "20", "orange", "10", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Add valid products multiple times to the cart and check valid products are added," +
            " Variant 1", new string[] {
                "positive"}, SourceLine=77)]
        public virtual void AddValidProductsMultipleTimesToTheCartAndCheckValidProductsAreAdded_Variant1()
        {
#line 69
this.AddValidProductsMultipleTimesToTheCartAndCheckValidProductsAreAdded("orange", "1", "orange", "2", "orange", "3", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Add valid products multiple times to the cart and check valid products are added," +
            " Variant 2", new string[] {
                "positive"}, SourceLine=77)]
        public virtual void AddValidProductsMultipleTimesToTheCartAndCheckValidProductsAreAdded_Variant2()
        {
#line 69
this.AddValidProductsMultipleTimesToTheCartAndCheckValidProductsAreAdded("apple", "9999", "orange", "1", "apple", "1", ((string[])(null)));
#line hidden
        }
        
        public virtual void AddAMixtureOfValidAndInvalidProductsToTheCartAndCheckValidProductsAreAddedAndInvalidOnesNot(string validProduct1, string validQuantity1, string invalidProduct2, string validQuantity2, string validProduct3, string validQuantity3, string validProduct4, string invalidQuantity4, string validProduct5, string validQuantity5, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "negative"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add a mixture of valid and invalid products to the cart and check valid products " +
                    "are added and invalid ones not", @__tags);
#line 84
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 85
 testRunner.When(string.Format("I add {0} with quantity {1} to the cart", validProduct1, validQuantity1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 86
 testRunner.And(string.Format("I add {0} with quantity {1} to the cart", invalidProduct2, validQuantity2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 87
 testRunner.And(string.Format("I add {0} with quantity {1} to the cart", validProduct3, validQuantity3), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 88
 testRunner.And(string.Format("I add {0} with quantity {1} to the cart", validProduct4, invalidQuantity4), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 89
 testRunner.And(string.Format("I add {0} with quantity {1} to the cart", validProduct5, validQuantity5), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 90
 testRunner.Then(string.Format("the cart contains a line item {0} with quantity {1}", validProduct1, validQuantity1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 91
 testRunner.And(string.Format("the cart does not contain a line item {0} with quantity {1}", invalidProduct2, validQuantity2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 92
 testRunner.And(string.Format("the cart contains a line item {0} with quantity {1}", validProduct3, validQuantity3), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 93
 testRunner.And(string.Format("the cart does not contain a line item {0} with quantity {1}", validProduct4, invalidQuantity4), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 94
 testRunner.And(string.Format("the cart contains a line item {0} with quantity {1}", validProduct5, validQuantity5), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Add a mixture of valid and invalid products to the cart and check valid products " +
            "are added and invalid ones not, orange", new string[] {
                "negative"}, SourceLine=96)]
        public virtual void AddAMixtureOfValidAndInvalidProductsToTheCartAndCheckValidProductsAreAddedAndInvalidOnesNot_Orange()
        {
#line 84
this.AddAMixtureOfValidAndInvalidProductsToTheCartAndCheckValidProductsAreAddedAndInvalidOnesNot("orange", "10", "banana", "2", "orange", "10", "apple", "-1", "apple", "1", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Add a mixture of valid and invalid products to the cart and check valid products " +
            "are added and invalid ones not, apple", new string[] {
                "negative"}, SourceLine=96)]
        public virtual void AddAMixtureOfValidAndInvalidProductsToTheCartAndCheckValidProductsAreAddedAndInvalidOnesNot_Apple()
        {
#line 84
this.AddAMixtureOfValidAndInvalidProductsToTheCartAndCheckValidProductsAreAddedAndInvalidOnesNot("apple", "1", "watermelon", "10", "apple", "2", "apple", "0", "orange", "9999", ((string[])(null)));
#line hidden
        }
        
        public virtual void AddAMixtureOfValidAndInvalidProductsToTheCartAndCalculateTheTotal(string validProduct1, string validQuantity1, string invalidProduct2, string validQuantity2, string validProduct3, string validQuantity3, string validProduct4, string invalidQuantity4, string validProduct5, string validQuantity5, string total, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "negative"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add a mixture of valid and invalid products to the cart and calculate the total", @__tags);
#line 101
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 102
 testRunner.When(string.Format("I add {0} with quantity {1} to the cart", validProduct1, validQuantity1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 103
 testRunner.And(string.Format("I add {0} with quantity {1} to the cart", invalidProduct2, validQuantity2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 104
 testRunner.And(string.Format("I add {0} with quantity {1} to the cart", validProduct3, validQuantity3), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 105
 testRunner.And(string.Format("I add {0} with quantity {1} to the cart", validProduct4, invalidQuantity4), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 106
 testRunner.And(string.Format("I add {0} with quantity {1} to the cart", validProduct5, validQuantity5), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 107
 testRunner.Then(string.Format("the total cost is {0} pence", total), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Add a mixture of valid and invalid products to the cart and calculate the total, " +
            "orange", new string[] {
                "negative"}, SourceLine=109)]
        public virtual void AddAMixtureOfValidAndInvalidProductsToTheCartAndCalculateTheTotal_Orange()
        {
#line 101
this.AddAMixtureOfValidAndInvalidProductsToTheCartAndCalculateTheTotal("orange", "10", "banana", "2", "orange", "10", "apple", "-1", "apple", "1", "560", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Add a mixture of valid and invalid products to the cart and calculate the total, " +
            "apple", new string[] {
                "negative"}, SourceLine=109)]
        public virtual void AddAMixtureOfValidAndInvalidProductsToTheCartAndCalculateTheTotal_Apple()
        {
#line 101
this.AddAMixtureOfValidAndInvalidProductsToTheCartAndCalculateTheTotal("apple", "1", "watermelon", "10", "apple", "2", "apple", "0", "orange", "9999", "250155", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion