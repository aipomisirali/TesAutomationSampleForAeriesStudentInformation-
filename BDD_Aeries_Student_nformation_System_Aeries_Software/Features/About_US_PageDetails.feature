Feature: AboutUs page is available
	    Write a test that ensures the Aeries Student Information System - Aeries Software website is available.
Write a test that ensures the ‘About Us’ link on the Aeries Student Information System - Aeries Software website is working.
This is found at the bottom of the page under ‘Company’
Write the results of the tests to the screen or a JSON file
Include any documentation that you deem necessary.
Push the project and any additional artifacts to GitHub and provide the link to us.


	
@Smoke
Scenario Outline: Validate AboutUs page is available
	Given User Navigates to < URL>
    When User Clicks About "About Us" 
	Then Verify user redirected for the following <textTitle>
Examples:
|URL                |textTitle                                                                                                   |
|https://aeries.com/|Delivering data-driven, intuitive, and innovative solutions that empower communities to advance student success.|