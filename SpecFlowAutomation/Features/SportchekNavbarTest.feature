Feature: SportchekNavbarTest
	In order to buy some products
	As a customer
	I want to navigate the site via navbar

@smoke
Scenario: Selecting Running subcategory from Women category should open page with products from Running subcategory
	Given customer opens Sportchek site
	When customer navigates to Women category on navbar
	And customer clicks Running subcategory 
	Then Running subcategory page is opened