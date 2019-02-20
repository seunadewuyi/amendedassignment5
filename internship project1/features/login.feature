Feature: Login
so that l can use the site
l need to login

@mytag
Scenario: valid login
	Given l navigate to giftrete url
	And click on login
	And enter my email address "omowunmi4mum@yahoo.com"
	And enter my password 
	When I click on sign in
	Then i should be able togin to the site

Scenario: invalid login (email address)
	Given l navigate to giftrete url
	And click on login
	And enter invalid email address
	And enter my password 
	When I click on sign in
	Then i should not be able to login, an error message should be displayed 

	Scenario:invalid login (password)
	Given l navigate to giftrete url
	And click on login
	And enter my valid email address (omowunmi4mum@yahoo.com)
	And enter invalid password
	When I click on sign in
	Then i should not be able to login, an error message should be displayed