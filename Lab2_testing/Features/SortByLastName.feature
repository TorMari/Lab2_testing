@setup_feature
Feature: SortByLastName

Scenario: Sorting customers in descending order of last name
	Given go to home page
	And click on the button 'Bank Manager Login'
	And click on the button 'Customers'
	When click on the button 'Last Name' in table
	Then customers list is sorted in descending order of last name
