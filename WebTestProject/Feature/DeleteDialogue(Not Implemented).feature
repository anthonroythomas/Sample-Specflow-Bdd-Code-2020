Feature: DeleteDialogue
As a user
I would like ensure I am deletinf the correct Timesheet ID


@regression
Scenario: Open Delete Dialogue
	Given the user is on the home page
	And a timesheet is present with a valid Timesheet ID in the table
	When the delete button is clicked
	Then the delete dialogue is opened

@regression
Scenario: Verify Timesheet ID Matches
	Given the user is on the home page
	And a timesheet is present with a valid Timesheet ID in the table
	When the delete button is clicked
	Then the delete dialogue is opened
	And the Timesheet ID matches the Timesheet ID from the table


