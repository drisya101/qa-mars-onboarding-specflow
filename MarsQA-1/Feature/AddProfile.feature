Feature: Add profile details
Priority: Major
As a Seller : I want to add my profile details
So that : The people seeking for some skills can look into my details

Background:
	Given I am logged in as a Seller

@automated
Scenario: Seller is able to add and view updated Description
	When Seller updates the description section with new <Description>
	Then Seller can view the new <Description>

	Examples:
		| Description                |
		| This is a test Description |

@automated
Scenario: Seller is able to add and view updated Language details
	When Seller updates the language section with <Language> and <Level>
	Then Seller can view the following language details <Language> and <Level>

	Examples:
		| Language | Level  |
		| English  | Fluent |

@automated
Scenario: Seller is able to add and view Education details
	When Seller updates the education section with below details
		| University | Country | Title | Degree | GraduationYear |
		| Otago      | Nepal   | B.Sc  | CS     | 2014           |
	Then Seller can view the updated Education details match the below
		| University | Country | Title | Degree | GraduationYear |
		| Otago      | Nepal   | B.Sc  | CS     | 2014           |

Scenario: Seller is able to add and view skill details
	When Seller updates the skill section with <Skill> and <Level>
	Then Seller can view the updated <Skill>

	Examples:
		| Skill | Level        |
		| C#    | Intermediate |

Scenario: Seller is able to add and view Certification details
	When Seller update the certification details with <Certificate> , <From> and  <Year>
	Then Seller can view the updated <Certificate> , <From> and <Year>

	Examples:
		| Certificate | From | Year |
		| C#          | 2021 | 2021 |

Scenario: Seller is able to add and view his work informations
	When Seller update the details with <Availability>, <Hours>, and <EarnTarget>
	Then Seller can view updated <Availability>, <Hours>, and <EarnTarget>

	Examples:
		| Availability | Hours                      | EarnTarget                |
		| Part Time    | Less than 30hours per week | More than $1000 per month |