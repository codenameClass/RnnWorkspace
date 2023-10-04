Feature: Generating INSZ-list

This feature validates the generation of Belgian social security numbers (INSZ/RRN).

Link to feature: [RNN](Rnn.Specs.Api/Features/GeneratingINSZList.feature)

#Rule: Should be able to generate a random list of INSZ-numbers

Scenario: User tries to generate a list of random INSZ-numbers without providing any input
	When the users asks for an INSZ generation
	Then the INSZ list should contain 1 randomly generated INSZ-number(s)

Scenario: User attempts to generate an list of 3 random INSZ-numbers
	When the users asks for an INSZ generation as 
		| amount |
		| 3      |
	Then the INSZ list should contain 3 randomly generated INSZ-number(s)

Scenario: User attempts to generate an list of -3 random INSZ-numbers
	When the users asks for an INSZ generation as 
		| amount |
		| -3     |
	Then the INSZ list should contain 1 randomly generated INSZ-number(s)

Scenario: User attempts to generate an list of 0 random INSZ-numbers
	When the users asks for an INSZ generation as 
		| amount |
		| 0      |
	Then the INSZ list should contain 1 randomly generated INSZ-number(s)

@technical
Scenario: User attempts to generate an list of random INSZ-numbers exceeding the allowed api-limit
	When the users asks for an INSZ generation as
		| amount	|
		| 123456789 |
	Then the ask attempt should fail with error "Internal server error"

#Rule: When generating a list of INSZ-numbers, there should be an option to include age and sex information alongside each generated number.

Scenario: User attempts to generate an list of 1 random INSZ-number that include age and sex information
	When the users asks for an INSZ generation as 
		| info |
		| true  |
	Then the INSZ list should contain 1 randomly generated INSZ-number(s) with associated age and sex

#Rule: Generation of INSZ-numbers must include an option to restrict it to adults.

Scenario: User attempts to generate an list of 1 random INSZ-number for an adult
	When the users asks for an INSZ generation as 
		| adult |
		| true   |
	Then the INSZ list should contain 1 randomly generated INSZ-number(s)
	And the INSZ-number(s) should be that of an adult

#Rule: INSZ-number Generation must offer a date-based restriction option.

Scenario: User attempts to generate an list of 1 random INSZ-number with the birthdate of 2022-10-30
	When the users asks for an INSZ generation as 
		| date       |
		| 2022-10-30 |
	Then the INSZ list should contain 1 randomly generated INSZ-number(s)
	And the INSZ-number(s) should start with 221030.

@missingfeature
Scenario: User attempts to generate an list of 1 random INSZ-number, with an incomplete birthdate
	When the users asks for an INSZ generation as 
		| date |
		| 2022 |
	Then the ask attempt should fail with error "Internal server error"

#Rule: INSZ-number Generation must be able to apply the above rules at the same time

Scenario Outline: User attempts to generate an INSZ-number with specific options

  When the users asks for an INSZ generation as
	| amount   | date        | info   | adult   |
	| <amount> | <birthdate> | <info> | <adult> |

  Then the INSZ list should contain <amount> randomly generated INSZ-number(s)

Examples:
  | amount  | birthdate  | info	 | adult	|
  | 1		| 1990-01-01 | true  | true		|
  | 3		| 1990-01-01 | true  | true		|
  | 1		| 2000-03-15 | true  | false	|
  | 3		| 2000-03-15 | true  | false	|
  | 1		| 1985-11-30 | false | true		|
  | 3		| 1985-11-30 | false | true		|