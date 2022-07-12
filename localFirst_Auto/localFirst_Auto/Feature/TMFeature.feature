Feature: Feature1

As a test student would like to check Create, Delete and Edit 
functions in TM page, So that time and material 
record of employee can be created, merged and tested.

@regression @create
Scenario: Create time and material record with valid credentials
Given I Logged into turnup portal sucessfully.
When I navigate in to time and material page.
And I create new Time and material record.
Then New time and material record created sucessfully

#@regression @edit
#Scenario: Edit time and material record with valid credentials
#Given I Logged into turnup portal sucessfully.
#When I navigate in to time and material page.
#And I create new Time and material record.
#And I edit Time and Material record
#Then New time and material record saved sucessfully