Feature: Wikipedia searching
    Navigate to the Wikipedia site
    Choose the English language
    Search for „Test Automation”
    Validate the following in this page: 
    Unit testing text
    Existence of Test Automation Interface Model picture
    Search for the link of Behavior driven development and navigate to there

@mytag
Scenario: Search
	Given Navigate to the Wikipedia site
	And Choose the English language
	And Search for Test Automation
	And Validate Unit testing text
	And Search for Test Automation Interface Model picture
	And Search for the link of Behavior driven development and navigate to there
	Then I should see Behavior driven development Wikipedia page