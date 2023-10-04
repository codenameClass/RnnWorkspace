Feature: Generating INSZ-list (dev)

This feature validates the generation of Belgian social security numbers (INSZ/RRN).

Link to feature: [RNN](Rnn.Specs.Api/Features/GeneratingINSZList.feature)

@technical@expectedtofail
Scenario: User attempts to generate an list of random INSZ-numbers exceeding the allowed api-limit
	When the users asks for an INSZ generation as 
		| amount |
		| 32301  |
	Then the ask attempt should fail with error "Internal server error"

@technical@experimental@expectedtofail
Scenario: User attempts to generate an list of random INSZ-numbers exceeding the allowed api-limit when date is specified with age and sex information included
	When the users asks for an INSZ generation as 
		| amount | date			| info	| adult |
		| 13925  | 2022-10-22	| true	| true	|
	Then the ask attempt should fail with error "Internal server error"

@technical@experimental@expectedtofail
Scenario: User attempts to generate an list of random INSZ-numbers exceeding the allowed api-limit with age and sex information included
	When the users asks for an INSZ generation as 
		| amount | info	|
		| 19887  | true	|
	Then the ask attempt should fail with error "Internal server error"