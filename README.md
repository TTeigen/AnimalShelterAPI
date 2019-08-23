# Travel API

#### _API for an animal shelter, 8/23/2019_

#### _By **Trevor Teigen**_

## Description

This API stores information about animals available for adoption and allows interaction with that data.

### Specs
| Spec | Input | Output |
| :-------------     | :------------- | :------------- |
| **Create new information for an animal** | "Tabby cat, 3 years old, male" | Information stored in the database via the POST method of the API. |
| Users shoud be able to create pages for new animals available at the shelter. |
| **Update Animal Information** | "Name: Larry Tabby cat, 3 years old, male is now 4 years old" | Larry's age updated in the database to 4 years old |
| Users can edit information about the animals in the shelter as needed |
| **See animal details** | "Interested in Tabby cats" | Shows a list of all Tabby cats in the shelter. |
| Users need to be able to find animals that fit what they are looking for and be able to see details about those animals.|
| **Ability to delete animals' information** | Remove this animal | _db.Animals.Remove(thisAnimal) |
| When an animal is adopted or no longer in the shelter the users need to be able to remove that animal's information from the database| 
| **Swagger implementation** | | |
| Swagger has been added to this API to help explain functionality of this API.| 



## Setup/Installation Requirements

* Clone this repository and >dotnet run in terminal
* Navigate through the website through the links

## Known Bugs
* No known bugs at this time.

## Technologies Used
* C#


## Support and contact details

_Please contact Trevor Teigen with questions and comments._

### License

*GNU GPLv3*

Copyright (c) 2019 **_Trevor Teigen_**