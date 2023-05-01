Feature: LanguageFeature

As a seller
I would like to add, update and remove language records
So that I can manage my profile successfully
@tag1
Scenario: Create a language record with valid details
	Given I logged into localhostweb portal successfully
	When I navigate to profile language page 
	And I create a new language record
	Then The language record should be added successfully

	Scenario Outline: Update existing language record with valid details
	Given I logged into localhostweb portal successfully
	When I navigate to profile language page
	And I update '<Language>','<LanguageLevel>' on an existing language record
	Then The language record should have the update '<language>','<languageLevel>'
	

Examples: 
| Language	| LanguageLevel			|
| English   | Fluent				|
| Sinhala	| Native/Bilingual		|
| Tamil     | Basic					|

Scenario Outline: Remove existing language record
	Given I logged into localhostweb portal successfully
	When I navigate to profile language page
	And I remove language record
	Then The language record should be removed successfully