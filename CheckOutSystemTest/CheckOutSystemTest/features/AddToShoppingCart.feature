Feature: Add products to shopping cart
	In order to purchase products
	As a customer
	I want to add products to my shopping cart

Background: Create a new cart
Given I have an empty shopping cart

@positive
Scenario Outline: Add Valid Products To the Cart
	When I add <product> with quantity <quantity> to the cart
	Then the cart contains a line item <product> with quantity <quantity>
	Examples: 
	| quantity | product | 
	| 1        | apple   | 
	| 1        | orange  | 
	| 2        | apple   | 
	| 1000     | orange  | 


@positive
Scenario Outline: Add Valid Products To the Cart and calculate Total
	When I add <product> with quantity <quantity> to the cart
	Then the total cost is <total> pence
	Examples: 
	| quantity | product | total |
	| 1        | apple   | 60    |
	| 1        | orange  | 25    |
	| 2        | apple   | 120   |
	| 1000     | orange  | 25000 |


@negative
#quantity must be positive integers
Scenario Outline: Add invalid quantity of products to the cart
	When I add <product> with quantity <quantity> to the cart
	Then the cart does not contain a line item <product> with quantity <quantity>
	Examples: 
	| quantity | product |
	| 0        | apple   |
	| -1       | orange  |
	| 0.5      | apple   |
	| 10.5     | orange  |


@negative
#only apple and orange are valid products	
Scenario Outline: Add invalid products to the cart and check valid products are added
	When I add <product> with quantity <quantity> to the cart
	Then the cart does not contain a line item <product> with quantity <quantity>
	Examples: 
	| quantity | product    |
	| 1        | banana     |
	| 2        | watermelon |


@negative
#only apple and orange are valid products	
Scenario Outline: Add invalid products to the cart and calculate total
	When I add <product> with quantity <quantity> to the cart
	Then the total cost is <total> pence
	Examples: 
	| quantity | product    | total |
	| 1        | banana     | 0     |
	| 2        | watermelon | 0     |


@positive
Scenario Outline: Add valid products multiple times to the cart and check valid products are added
	When I add <product1> with quantity <quantity1> to the cart
	And I add <product2> with quantity <quantity2> to the cart
	And I add <product3> with quantity <quantity3> to the cart
	Then the cart contains a line item <product1> with quantity <quantity1>
	And the cart contains a line item <product2> with quantity <quantity2>
	And the cart contains a line item <product3> with quantity <quantity3>
	Examples: 
	| product1 | quantity1 | product2 | quantity2 | product3 | quantity3 |
	| orange   | 10        | apple    | 20        | orange   | 10        |
	| orange   | 1         | orange   | 2         | orange   | 3         |
	| apple    | 9999      | orange   | 1         | apple    | 1         |


@negative
Scenario Outline: Add a mixture of valid and invalid products to the cart and check valid products are added and invalid ones not
	When I add <validProduct1> with quantity <validQuantity1> to the cart
	And I add <invalidProduct2> with quantity <validQuantity2> to the cart
	And I add <validProduct3> with quantity <validQuantity3> to the cart
	And I add <validProduct4> with quantity <InvalidQuantity4> to the cart
	And I add <validProduct5> with quantity <validQuantity5> to the cart
	Then the cart contains a line item <validProduct1> with quantity <validQuantity1>
	And the cart does not contain a line item <invalidProduct2> with quantity <validQuantity2>
	And the cart contains a line item <validProduct3> with quantity <validQuantity3>
	And the cart does not contain a line item <validProduct4> with quantity <InvalidQuantity4>
	And the cart contains a line item <validProduct5> with quantity <validQuantity5>
	Examples: 
	| validProduct1 | validQuantity1 | invalidProduct2 | validQuantity2 | validProduct3 | validQuantity3 | validProduct4 | InvalidQuantity4 | validProduct5 | validQuantity5 |
	| orange        | 10             | banana          | 2              | orange        | 10             | apple         | -1               | apple         | 1              |
	| apple         | 1              | watermelon      | 10             | apple         | 2              | apple         | 0                | orange        | 9999           |

@negative
Scenario Outline: Add a mixture of valid and invalid products to the cart and calculate the total
	When I add <validProduct1> with quantity <validQuantity1> to the cart
	And I add <invalidProduct2> with quantity <validQuantity2> to the cart
	And I add <validProduct3> with quantity <validQuantity3> to the cart
	And I add <validProduct4> with quantity <InvalidQuantity4> to the cart
	And I add <validProduct5> with quantity <validQuantity5> to the cart
	Then the total cost is <total> pence
	Examples: 
	| validProduct1 | validQuantity1 | invalidProduct2 | validQuantity2 | validProduct3 | validQuantity3 | validProduct4 | InvalidQuantity4 | validProduct5 | validQuantity5 | total   |
	| orange        | 10             | banana          | 2              | orange        | 10             | apple         | -1               | apple         | 1              | 560     |
	| apple         | 1              | watermelon      | 10             | apple         | 2              | apple         | 0                | orange        | 9999           | 250155|

