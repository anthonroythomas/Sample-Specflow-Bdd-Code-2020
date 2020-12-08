Feature: Create New Timesheet
	In order to create new timesheets
	As a user I want to generate timesheets via the UI

@regression
Scenario: Adding a new Timesheet does not create an error 
	Given the user is on the home page
	And the Create New button is pressed
	And the user is navigated to Create or Edit Page
	And the user enters a valid Emplyee ID
	And the user enters a valid Houry Rate
	And the user selects a Day
	And the user Selects Hours
	And the user Selects Minutes
	When the user clicks the Save button
	Then the user is taken to a valid summary page

@regression
Scenario: A new timesheet takes user to the Timesheet Summary Page
	Given the user is on the home page
	And the Create New button is pressed
	And the user is navigated to Create or Edit Page
	And the user enters a valid Emplyee ID
	And the user enters a valid Houry Rate
	And the user selects a Day
	And the user Selects Hours
	And the user Selects Minutes
	And the user submits the time
	When the user clicks the Save button
	Then the user is taken to a valid summary page


