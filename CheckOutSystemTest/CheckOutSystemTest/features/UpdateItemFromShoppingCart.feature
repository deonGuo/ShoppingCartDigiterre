Feature: UpdateItemFromShoppingCart
	In order to make changes to the shopping cart
	As a customer
	I want to update item lines from my shopping cart


@positive
#add 3 items to the cart, remove 2, verify the removed ones are gone and the other one remains
Scenario Outline: Update 2 line items from cart
	Given the cart has an item line of <product1> with quantity <quantity1>	
	And the cart has an item line of <product2> with quantity <quantity2>
	And the cart has an item line of <product3> with quantity <quantity3>	
	When I update item line of <product1> with quantity <quantity1> to quantity <quantity1s> from the cart
	And I update item line of <product2> with quantity <quantity2> to quantity <quantity2s> from the cart
	Then the cart contains a line item <product1> with quantity <quantity1s>
	And the cart contains a line item <product2> with quantity <quantity2s>
	And the cart contains a line item <product3> with quantity <quantity3>
	And the cart does not contain a line item <product1> with quantity <quantity1>
	And the cart does not contain a line item <product2> with quantity <quantity2>
	Examples: 
	| product1 | quantity1 |  quantity1s |product2 | quantity2 | quantity2s | product3 | quantity3 |
	| apple    | 1         |  10         |orange   | 2         | 20         | apple    | 3         |
	| orange   | 1         |  10         |orange   | 2         | 20         | orange   | 3         | 



#to implement
Scenario: update line items that do not exist

#to implement
Scenario: update quantity to invalid amount (0, negative, float)

