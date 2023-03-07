# ASP API project

## Why?
This is a project created to fullfil assignment for one of the interview stages. 

## Assignment requirements
- Use LTS version of dotnet
	- Assumption! .net = .net (not core)
	- At the moment of project creation (28.02.2023) it's .net v6.0.14
- Should be in 1 solution
- Must be a git repository
- Use Controller for the different assignment
	- Assumption! There should be api endpoints using both Controller & MinimalAPI
- OpenAPI/Swagger should be use for the API

## TODO / Assignments
1. [X] - Create an endpoint "/fizzbuzz" that returns a list
	- Assignment description was hard to understand, so there will be plenty of assumptions
	- Endpoint name - /fizzbuzz
	- Endpoint method - Assumption! Absence of input points that it's a GET request
	- Input - none described, therefore assumption it's not present
	- Output - JSON object/response with "input value and the result"
		- Example result: a newline delimited list, from 0 to 30. 
			- If the value is divisible by 3, show “fizz” 
			- If it is dividable by 5, show “buzz”. 
			- Otherwise, show the number.
		- Assumption! Assignment mentions input only in an output, but not what that input should be, so I am assuming that's a mistake in description
2. [X] - Create an endpoint
	- Assignment description: take in an array of values and make a sum of it
	- Example Input with Example Output
		- Input: ["42", "1e3", "1.222", null, "-12"]
		- Output for the input above: 2252
	- Endpoint name - /sum
	- Endpoint method - Post request with body containing input
	- Input - an array of string | null - (string|null)[]
		- values might include integers, exponentials or nulls
		- Integers could be both positive or negative
		- Based on example input and output 1e3 here is an exponential number writing and not a hexadecimal (1e3 = 1000 vs 1E3 = 438)
		- Based on example floating devided at comma, not period, because "1.222" = 1222, not 1 + 0.222
		- Assumption! Null will be converted to zero
	- Output - a sum of converted string returned as a string
3. [X] - Create an endpoint "/runningtotal" with persisting collection
	- Assignment description: Return a sum of last 3 submitted numbers. Body should consist of only number
	- Example Inputs -> Example Output
		- 4 -> 4
		- 2 -> 6
		- 5 -> 11
		- 7 -> 14
		- 1 -> 13
	- Endpoint name - /runningtotal
	- Endpoint method - Post request with body containing a number
	- Input - a number in a body
		- Assumption! Body will be a JSON object with a field "number" in it, whose value will be used
	- Output - a sum of last 3 numbers
		- Meaning 2 previous results needs to be persisted
		- Assumption! Defaul value for persistant values will be 0
