Feature: ManageAdminUser
As Orange HRMs administration,
I would like to manage user profiles within the portal

@sanity
Scenario: Add a new admin user
	Given I login to Orange HRM portal as an administration
	And I navigate to systems user page
	Then I should be able to create a new user successfully

@regression @sanity
Scenario: Edit an existing admin user
	Given I login to Orange HRM portal as an administration
	And I navigate to systems user page
	Then I should be able to edit an existing user successfully

@smoke
Scenario: Delete an existing admin user profile
	Given I login to Orange HRM portal as an administration
	And I navigate to systems user page
	Then I should be able to delete an existing user successfully


@sanity
Scenario Outline: Create multiple employees
	Given I login to Orange HRM portal as an administration
	And I navigate to systems user page
	Then I should be able to create multiple '<employees>' successfully
	Examples: 
	| employees |
	| Epsita    |
	| Anmol     |
	| Test      |	