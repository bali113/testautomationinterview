Feature: Navigation bar
	In order to to browse the site
	As an user
	I want to use the navigation bar

@navigation
Scenario: Browse to Form page
	Given I am on the Home page
	And Home button active
	When I clicks on Form button
	Then I should land on From page
	And From button should turn to active status

@navigation
Scenario: Browse to Home page
	Given I am on the Form page
	And Form button active
	When I clicks on Home button
	Then I should land on Home page
	And Home button should turn to active status

@navigation
Scenario: Clicks to UI Testing button
	Given I am on the Home page
	And Home button active
	When I clicks on UI Testing button
	Then I should land on Home page
	And Home button should turn to active status

@navigation
Scenario: Clicks to UI Testing button on Form page
	Given I am on the Form page
	And Form button active
	When I clicks on UI Testing button
	Then I should land on Home page
	And Home button should turn to active status

@navigation
Scenario: Browse to Error page
	Given I am on the Form page
	When I clicks on Error button
	Then I should land on Error page
	And I should get a 404 HTTP response code