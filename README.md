# Test_assignment_2
## Reflections 

### COMPUTER MOUSE 
Identify the types of testing you would perform on a computer mouse, to make sure that it is of the highest quality. 
		
There’s many different types of test you can perform on a computer mouse, to make 
sure that it is of the highest quality. Although it depends on what the highest quality means. What are you going to use the mouse for? What kind of quality are you looking for? 
If you’re looking for at good mouse for everyday work, test could look like this:

1. Check if the mouse is an optical mouse or not.
2. Verify that left-click and right-click buttons are working fine.
3. Check if the double click is working fine.
4. Verify the time duration between two left clicks, in order to consider it as a double click.
5. Check if the scroller is present at the top or not.
6. Verify the speed of the mouse pointer.
7. Check the pressure required for clicking the mouse buttons.
8. Verify the acceleration of the mouse pointer.
9. Verify that clicking the button and dragging the mouse operation is working fine(drag and drop functionality).
10. Check the dimension of the mouse, if it’s suitable to grip and work.
11. Verify that the mouse works on all the allowed surfaces.
12. Check if the mouse is a wireless mouse or corded mouse.
13. In the case of a wireless mouse, check the range up to which the mouse remains operational.
14. In the case of a wireless mouse, check the battery requirement of the mouse.

### CATASTROPHIC FAILURE 
Find a story where a software system defect had a bad outcome. Describe what happened. Can you identify a test that would have prevented it? 

### National Health Service
I don’t know what is worse: Not taking your medicines at all or taking the wrong medication. Either way, at least 300,000 heart patients were given the wrong drug or advice as a result of a software fault. So, what happened? In the year 2016, it was discovered that the clinical computer system SystmOne had an error that since 2009 had been miscalculating a patient's risk of heart attack. As a result, many patients suffered heart attacks or strokes since they were told they were at low-risk, while other suffered from the side-effects of taking unnecessary medication
To prevent an incident like that, proper testing of the function that calculated the risk of heart attack could have prevented most of the error if not all. I will assume that the system had been tested before going into production, but apparently not good enough. 

You could perform a Test Scenario to cover all possible outcomes. Test Scenario covers these 5 steps to make sure that all aspects of the system are covered. 

Step 1: Read the Requirement Documents.  You could also refer to use cases, books, manuals, etc. of the application to be tested.

Step 2: For each requirement, figure out possible users actions and objectives. Determine the technical aspects of the requirement.

Step 3: After reading the Requirements Document and doing your due Analysis, list out different test scenarios that verify each feature of the software.

Step 4: Once you have listed all possible Test Scenarios, a Traceability Matrix is created to verify that each & every requirement has a corresponding Test Scenario

Step 5: The scenarios created then have to be reviewed by someone else. 

### SRING UTILITY 
- Given I want to reverse a string 
- When I input any string
- Then I get a reverse string returned

- Given I want to uppercase a string
- When I input any string
- Then I get a uppercase string returned

- Given I want to lowercase a string
- When I input any string
- Then I get a lowercase string returned

### INVESTIGATION OF TOOLS

@Tag 

- Give a test a tag and create test suites to run only test with the tag 

@Disable

- Means that the test will not run 

@RepeatedTest

- A way to write any test that we want to repeat several times.

@BeforeEach, @AfterEach

- Do something before/after each test 


@DisplayName

- Create displayname for the test

@Nested

- Makes it possible to organize big test classes

AssumeFalse

- Assumes the test will fail

AssumeTrue

- Assumes the test will succeed 
