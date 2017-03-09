Feature: ValtechNavigation
As a customer
I want to be able to navigate around the Valtech website
so that I can read about the company

Scenario: Navigate to the Valtech Homepage and check the latest news.
	Given I have navigated to the valtech Homepage
	When I view the Homepage
	Then the latest news section is displayed

Scenario: Navigate to the Valtech Cases Page.
	Given I have navigated to the valtech Homepage
	And I have navigated to the valtech Cases Page
	When I view the Cases Page
	Then the Work header 'Work' is displayed

Scenario: Navigate to the Valtech Services Page.
	Given I have navigated to the valtech Homepage
	And I have navigated to the valtech Services Page
	When I view the Services Page
	Then the Services header 'Services' is displayed

Scenario: Navigate to the Valtech Job Page.
	Given I have navigated to the valtech Homepage
	And I have navigated to the valtech Job Page
	When I view the Job Page
	Then the Careers header 'Careers' is displayed

Scenario: Navigate to the Valtech About Us Page, count the offices.
	Given I have navigated to the valtech Homepage
	And I have navigated to the valtech About Us Page
	When I click on the Valtech Offices link to view the Contact Us page
	Then I can count and output the number of valtech offices