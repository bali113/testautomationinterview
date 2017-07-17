Feature: Login
	Check login functionality
    User should get redirect to the Hello page
	Login text should appear

@login
Scenario: Login users
	Given I navigate to the Form page
	And I enter <value>
		| <value> |
		| John    |
		| Sophia  |
		| Charlie |
		| Emily   | 
	And I click on button
	Then I sould see <result> login text
		| <result>      |
		| Hello John!   |
		| Hello Sophia! |
		| Hello Charlie!|
		| Hello Emily!  |