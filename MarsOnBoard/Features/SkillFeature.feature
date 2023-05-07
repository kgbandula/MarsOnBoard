Feature: SkillFeature

As a seller
I would like to add, update and remove skill records
So that I can manage my profile successfully

@tag1
Scenario: Create skill record with valid details
	Given I logged into localhost portal successfully
	When I navigate to profile skill page
	And I create a new skill record
	Then The record should be added successfully

Scenario Outline: Edit an existing skill record with valid details
	Given I logged into localhost portal successfully
	When I navigate to profile skill page
	And I update '<Skill>','<SkillLevel>' on an existing skill record
	Then The record should have the updated '<skill>','<skillLevel>'	

Examples: 
| Skill               | SkillLevel   |
| Negotiation         | Beginner     |
| Attention to detail | Intermediate |
| Collaboration       | Expert       |

Scenario: Remove and existing skill record
	Given I logged into localhost portal successfully
	When I navigate to profile skill page
	And I remove skill record
	Then The record should be removed successfully