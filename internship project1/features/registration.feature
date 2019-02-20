Feature: Registration 
	i will like to register
	so that l can login to the site

@mytag
Scenario: Valid registration
	Given I navigate to the Giftrete url
	When I click Register
	And enter my Firstname
And enter my Lastname
	And enter my email " omowunmi4mum@yahoo.com"
And enter my mobile number
And enter my password
And enter i confirm my password
	And click on sign up
Then the registration page is displayed

Scenario: Invalid registration(email)
	Given I navigate to the Giftrete url
	When I click Register
	And enter my Firstname
And enter my Lastname
	And enter an invalid email
And enter my mobile number
And enter my password
And enter i confirm my password
	And click on sign up
Then the registration page is has an error

Scenario: Invalid registration(password)
	Given I navigate to the Giftrete url
	When I click Register
	And enter my Firstname
And enter my Lastname
	And enter my email " omowunmi4mum@yahoo.com"
And enter my mobile number
And enter my an invalid email
And enter i confirm my password
	And click on sign up
Then the registration page is not displayed and you get an error message

Scenario: Invalid registration (mobile number)
	Given I navigate to the Giftrete url
	When I click Register
	And enter my Firstname
And enter my Lastname
	And enter my email " omowunmi4mum@yahoo.com"
And enter my invalid mobile number
And enter my password
And enter i confirm my password
	And click on sign up
Then the registration page is not displayed 


