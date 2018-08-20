Feature: Remove item lines from shopping cart
	In order to not purchase items I no longer want
	As a customer
	I want to remove item lines from my shopping cart

#Background: Create a new cart
#Given I have an empty shopping cart
#And I add apple with quantity 10 to the cart
#And I add orange with quantity 20 to the cart
#And I add apple with quantity 30 to the cart
#And I add orange with quantity 40 to the cart

@testInjection
Scenario: cart test injection
Given I have an empty shopping cart
And I add apple with quantity 10 to the cart
And I add orange with quantity 20 to the cart
When I display cart content 

@positive
Scenario Outline: Remove 1 existing lineItem from cart
	Given the cart has an item line of <product> with quantity <quantity>
	When I remove item line of <product> with quantity <quantity> from the cart
	Then the cart does not contain a line item <product> with quantity <quantity>
	Examples: 
	| product | quantity |
	| apple   | 1        |
	| apple   | 99       |
	| orange  | 5        |


@negative
Scenario Outline: Remove an line item from empty Cart
	When I remove item line of <product> with quantity <quantity> from the cart
	Then the cart does not contain a line item <product> with quantity <quantity>
	Examples: 
	| quantity | product | 
	| 1        | apple   | 
	| 1        | orange  | 
	| 2        | banana   | 
	| -100     | orange  | 

@negative
#only removing matching item lines (product + quantity)
Scenario Outline: Remove an line item from Cart that contains item lines of same product but different quantity
	Given the cart has an item line of <product> with quantity <quantity1>	
	When I remove item line of <product> with quantity <quantity2> from the cart
	Then the cart contains a line item <product> with quantity <quantity1>
	Examples: 
	| product | quantity1 | quantity2 |
	| apple   | 1         | 2         |
	| orange  | 2         | 1         | 

@positive
#add 3 items to the cart, remove 2, verify the removed ones are gone and the other one remains
Scenario Outline: Remove 2 line items from cart
	Given the cart has an item line of <product1> with quantity <quantity1>	
	And the cart has an item line of <product2> with quantity <quantity2>
	And the cart has an item line of <product3> with quantity <quantity3>	
	When I remove item line of <product1> with quantity <quantity1> from the cart
	And I remove item line of <product2> with quantity <quantity2> from the cart
	Then the cart contains a line item <product3> with quantity <quantity3>
	And the cart does not contain a line item <product1> with quantity <quantity1>
	And the cart does not contain a line item <product2> with quantity <quantity2>
	Examples: 
	| product1 | quantity1 | product2 | quantity2 | product3 | quantity3 |
	| apple    | 1         | orange   | 2         | apple    | 3         |
	| orange   | 1         | orange   | 2         | orange   | 3         | 


#to implement
Scenario: Remove an line item from cart that contains multiple matching line items

#to implement
Scenario: Remove all line items from cart