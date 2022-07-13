Feature: TMFeature

As a test student would like to check Create, Delete and Edit 
functions in TM page, So that time and material 
record of employee can be created, merged and tested.

@regression @create
Scenario: 1 Create time and material record with valid credentials
Given I Logged into turnup portal sucessfully.
When I navigate in to time and material page.
And I create new Time and material record.
Then New time and material record created sucessfully

@regression @edit
Scenario: 2  Edit time and material record with valid credentials
Given I Logged into turnup portal sucessfully.
When I navigate in to time and material page.
When I updated '<Description>', '<Code>','<Price>' on existing Time and material record.
Then The record should have the updated '<Description>','<Code>','<Price>'

Examples: 
| Description | Code | Price  |
| Keyboard    | How  | $54.00  |
| Pen         | When | $1.00    |
| EditedRow   | Why  | $900,000.00 |
