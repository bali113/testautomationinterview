Feature: HomePageTexts
	In the Home page
	As a user
	I want to want to see content of texts

@homepagetexts
Scenario: Landing on Home page
	Given I am landing on Home page
	When the page loads the "Welcome to the Docler Holding QA Department" text should be visible
	Then the "This site is dedicated to perform some exercises and demonstrate automated web testing." text should be visible
