Feature: CertificationsFeature

As a seller
I would like to add, update and remove certification records
So that I can manage my profile successfully

@tag3
Scenario: Create a certification record with valid details
	Given I logged into myskill portal successfully
	When I navigate to profile certification page 
	And I create a new certification record
	Then The certification record should be added successfully	
	
Scenario Outline: Edit an existing certification record with valid details
	Given I logged into myskill portal successfully
	When I navigate to profile certification page
	And I update '<Certificate>','<From>','<Year>' on an existing certificate record
	Then The certificate record should have the updated '<certificate>','<from>''<year>'	

Examples: 
| Certificate         | From                  | Year |
| Key Board           | Langway               | 2003 |
| Education           | University of Colombo | 2015 |
| Information Systems | SLIIT                 | 2010 |

Scenario: Remove an existing certification record
	Given I logged into myskill portal successfully
	When I navigate to profile certification page
	And I remove certificate record
	Then The certificate record should be removed successfully