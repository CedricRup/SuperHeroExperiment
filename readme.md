# The Super Hero Experiment
## Main goals of the hands-on :
* Strengthen collaboration between different profiles (Dev, Ops, Testers, Security, Product Owners, Architects )
* Experiment new ways of working together (DevOps, Agile, Example Mapping)

## Before playing

The Hero Corp site is needed to run the hands-on. The participants app will be required to call the API in order to request hero characteristics. It also serves as documentation point for participants

### Run the Hero Corp site on a local machine

You'll need Java 8 runtime environment. To run the site, go at the root of the repository and launch

```
.\gradlew bootFullApplication
```
Default port is 8080

If you intent to use a local computer to run he game, make sure that other computers can reach it

### Host the Hero Corp site somewhere else

Build the app with 

```
.\gradlew packageFullApplication
```

The result jar is in the back/build/libs directory

You'll need a Java 8 enable environment to launch the app


```
java -jar heroCorp-0.1.0.jar
```

The app is a spring boot fat jar, see Spring Boot documentation to tweak execution.

See you hosting environment for more details ;o)

### Use a preinstalled version

https://superheroexperiment.azurewebsites.net

Service is not garanteed ;o)

### Grab the slides and the docs

Consult the Hero Corp website to grab your slides and some technical docs for the participants  

## Your mission as facilitator:
Facilitate a safe environment for one or two teams that you are in charge of, answers theirs questions, getting needed information, so that they can reach their goals

Checklist before the hands-on
* A designated space/room for the team
* Wall spaces or flipcharts so that the team can use as a board with post-its
* Sets of Post-its and markers
* A way to show the slides
* Capacity to run the Oracle

## Team
Must have roles: 
* Dev
* QA
* OPS
* observer  

“Good to have” roles:
* Security
* Architecture
* Data scientist


Observer will take notes of what the team is doing during the experience, how do they organize? What dynamic do you see? What questions come to you when you see that. You will share these notes to the team. You will discuss and decide with emissary about what badges to give to the team


## Generalities
Welcome all participants of the teams that you are in charge of.

Example:
```
"Welcome to the Super Hero Experiment. You’ll have 6 hours to experiment, to collaborate, to learn and have fun together.

I am XXX, your emissary for the remainder of this event. I’ve been mandated by the Hero Corporation to help you build your application. We’ve been asked to handle some extraordinary situations for you. We’re counting on you to make the finest usage of our time and powers and to respect the rules that will ensure our safety.

First of all, do you have your team name? If so, please write it on your chart in BIG CHARACTERS. If you don’t have one, I can think of something"

(Ex: The A-Team,The Autobots,The Avengers,The BPRD,The Fantastic 20,The Green,Lanterns,The Guardians of the Galaxy,The Justice League,The League of,Extraordinary Gentlemen,The Teen Titans,The Thundercats,The X-Men)


I’m sure you must have a lot of question.  Maybe we can start by some generalities on the future app before getting into the super hero rules? What questions do you have for me?
```

Warning: You are forbidden to write anything down. Find an excuse like “Pens are like kryptonite to me” or “if I show this to you I’ll have to ban you in another dimension”
* Any discovery is made by conversation only: emissary can not write, the teams can.
* Participants can ask as many questions they like. If the question is relevant to the business rules, you will answer. If not, you may elude, or improvise a goofy response as long as it doesn’t modify the agreed business rules.
* Don’t forget to look out for badge attribution. Some eligible badges for this phase are for good practices like: story mapping, communication tool
* Always give them the minimum information to answer their question. Don’t spoil business rules. Or just give them a hint. 
* If they want to code, let them!
* First state the business rule bluntly, give examples only if requested.
* If they ask you for something technical
 * If it’s about their API, point them to the spec documents on the Hero Corp Site
 * If it’s about other implementation details, answer “Hey, that’s your part. I’m not Tony Stark”
* Write their badges on their team chart.


Ask them if they have questions about the generalities, then tell them about the events we can handle, begin with the Tsunami Prevention, Meteorite Prevention, Tsunami Repair, Meteorite Repair 


Below are some information you will require to answer participants' questions:

* API Inputs (POSTs that the API accepts) : heroes, events
* API Output (GET that the api gives) : intervention plan

Hero register on the app when they have free time, you can’t choose the hero you want.
When they are available, they push a button on the tech gizmo, the gizmo send a registration to the API

Event comes from some other systems that monitor activity on earth. When they detect something important happening, a event is pushed to the API.

Your application must calculate an intervention plan, i.e. tell which hero handle what event. The tech gizmo request the intervention plan on regular basis. 

Distance is not an issue heroes have teleporters.

An Event can be either prevented or repaired
* If it’s prevented, more lifes are saved. You must prevent in priority
* If it can’t be prevented, it has to be repaired
* You don’t have to repair if you prevent

The stand-by rule : when heroes register, they go in the Batcave and are in stand-by

The End of mission rule : when a End Of Mission event is received, all heroes are relieved from their duties, the intervention plan is empty. 

Kinds of event we can handle:
* Tsunami
* Meteorite
 
Not implemented but fun to talk about to confuse participants:
* Earthquake
* Godzilla Attack
* Villain mischiefs
* Magical Hurricane
* Draught 

Heroes can have a combination of Water, Fire, Earth and Air Power

The powers of each hero is not directly on the Hero Corp Site but has to be inferred (see power determination rules).

Heroes Characteristics can be found in the Hero Corp Site 

Water and Fire are not compatible. Water is dominant
Air and Earth are not compatible. Air is dominant

Legit Combinations :
* Air and Fire
* Air and Water
* Water and Earth
* Earth and Fire

# Running the oracle

Some automatic tests implemented as Cucumber scenario can help you guide your team.

To run these tests, go at the root of the repository and run

```
.\gradlew cucumber -PteamName=theTeamName -Purl=theFullUrlOfYourTeamApi

```

You wll find the results in the oracle/testResults directory

# Rules summary
## Main rules
* Rule 1  : When a hero register, he is in standby in the Batcave
* Rule 2: When the “End Of Mission” event is signaled, all heroes are freed, the intervention plan is empty
* Rule 3: You can prevent a Tsunami with Water
* Rule 4: If you can’t prevent a Tsunami, you can repair it with a Air enabled hero
* Rule 5: No need to repair if you can prevent
* Rule 6: You need Fire to prevent a meteorite
* Rule 7: if a meteorite can't be prevented, a water able hero must be send  
* Rule 8: A hero has Water power if her name contains “water”, “ice” or “aqua”
* Rule 9: A hero has fire power if she has Red or Yellow eyes
* Rule 10: A hero has earth power on a place if year of appearance + sum of ascii code of location is divisible by 17
* Rule 10: A hero has earth power on a place if year of appearance + sum of ascii code of location is divisible by 17

## SECURITY
* Rule 11: Existing heroes without incorrect credential can't register
* Rule 12: Unknown heroes can't register
* Rule 13: Villains can't log in
* Rule 14: You can register a neutral Hero
* Rule 15: Hero with no alignment are considered neutral
* Rule 16: Can't register a fallen Hero

## BONUS
* Rule 17: A hero can't have water and fire power, water is dominant
* Rule 18: Cannot have earth and air power, air is dominant
* Rule 19: Hero Aang has all powers everywhere ;o)
* Rule 20: Always prevent and repair the strongest events
* Rule 21 : If the event cannot be prevented nor repaired, event strength * 2 of heroes must go the the place

# Rules details
## Event Handling
Each big event can be either prevented or repaired according to available heroes power. See Power determination section to know heroes powers

### Rule 1: When a hero register, he is in standby in the Batcave
```gherkin   
Given these heroes registrations
| Name             |
| Aquaria Neptunia |
| Iceman           |
Then the intervention plan should be
| Hero             | Location | Action  |
| Aquaria Neptunia | Batcave  | Standby |
| Iceman           | Batcave  | Standby |
```
### Rule 2: When the “End Of Mission” event is signaled, all heroes are freed, the intervention plan is empty
```gherkin
Given these heroes registrations
| Name             |
| Aquaria Neptunia |
| Iceman           |
When these events occur
| Type           | Location |
| End of Mission | Secret   |
Then the intervention plan should be empty
```

### Rule 3: You can prevent a Tsunami with Water
```gherkin
Given “Aquaria Neptunia” has Water power
Given these heroes registrations
| Name             |
| Aquaria Neptunia |
 When these events occur
| Type    | Location |
| Tsunami | New York |
Then the intervention plan should be
| Hero             | Location | Action  |
| Aquaria Neptunia | New York | Prevent |
```
### Rule 4: If you can’t prevent a Tsunami, you can repair it with a Air enabled hero
```gherkin
Given “Lasher” has Air power
Given these heroes registrations
| Name   |
| Lasher |
When these events occur
| Type    | Location |
| Tsunami | New York |
Then the intervention plan should be
| Hero   | Location | Action |
| Lasher | New York | Repair |
```
### Rule 5: No need to repair if you can prevent
```gherkin
Given “Lasher” has Air power
Given “Aquaria Neptunia” has Water power
Given these heroes registrations
| Name             |
| Lasher           |
| Aquaria Neptunia |
When these events occur
| Type    | Location |
| Tsunami | New York |
Then the intervention plan should be
| Hero             | Location | Action  |
| Aquaria Neptunia | New York | Prevent |
| Lasher           | Batcave  | Standby |
```
### Rule 6: You need Fire to prevent a meteorite
```gherkin
Given “Cornfed” has Fire power   
Given these heroes registrations
| Name    |
| Cornfed |
When these events occur
| Type      | Location |
| Meteorite | New York |
Then the intervention plan should be
| Hero    | Location | Action  |
| Cornfed | New York | Prevent |
```
### Rule 7: if a meteorite can't be prevented, a water able hero must be send
```gherkin
Given “Aquaria Neptunia” has Water power   
Given these heroes registrations
| Name             |
| Aquaria Neptunia |
When these events occur
| Type      | Location |
| Meteorite | New York |
Then the intervention plan should be
| Hero             | Location | Action |
| Aquaria Neptunia | New York | Repair |
```
## Power determination
Heroes can have a combination of Water, Fire, Earth and Air powers. In order to know what kind of powers a hero has, you need to check some specific characteristics that are available on the Hero API

### Rule 8: A hero has Water power if her name contains “water”, “ice” or “aqua” 
```gherkin
When powers are determined for "Iceman"
Then this hero has "Water" Power

When powers are determined for "Charles Blackwater"
Then this hero has "Water" Power

When powers are determined for "Aquaria Neptunia"
Then this hero has "Water" Power

When powers are determined for "Fire Dragon"
Then this hero has no "Water" Power
```

### Rule 9: A hero has fire power if she has Red or Yellow eyes
```gherkin
Given hero “Cornfeld” has Red Eyes
When powers are determined for "Cornfed"
Then this hero has "Fire" Power

Given hero “Illich Lavrov” has Yellow Eyes
When powers are determined for "Illich Lavrov"
Then this hero has "Fire" Power

Given hero “Superman” has Blue Eyes
When powers are determined for "Superman"
Then this hero has no "Fire" Power
```

### Rule 10: A hero has earth power on a place if year of appearance + sum of ascii code of location is divisible by 17
```gherkin
Given “Aleister Hook” first appeared on March 1988
When powers are determined for "Aleister Hook" in "Paris"
Then this hero has "Earth" Power

Explanation :
P = 80
a = 97
r = 114
i = 105
s = 115

(80 + 97 + 114 + 105 + 115 + 1988) mod 17 = 0, divisible by 0


When powers are determined for "Aleister Hook" in "Parit"
Then this hero has no "Earth" Power

Explanation :
P = 80
a = 97
r = 114
i = 105 
t = 116

(80 + 97 + 114 + 105 + 116 + 1988) mod 17 = 1, not divisible by 17 
```

### Rule 11: A hero has Air power if he is bald and first appeared on a month without an "r" in it
```gherkin
Given “Lasher” first appeared on “May 1993”
And “Lasher” is bald
When powers are determined for "Lasher"
Then this hero has "Air" Power

Given “Charles Xavier” first appeared on “sept-63”
And “Charles Xavier” is bald
When powers are determined for "Charles Xavier"
Then this hero has no "Air" Power

Given “Ororo Monroe” first appeared on “May 1975”
And “Ororo Monroe” has white hair
When powers are determined for "Ororo Monroe"
Then this hero has no "Air" Power
```

## SECURITY RULES:
Registration have a secret “key” property that acts like a password

### Rule 10: Existing heroes with the correct credential can register
```gherkin
When a hero called "Spider-man" tries to register with the key "7effb551-5364-48cb-9014-a36fd7068619"
Then the registration is a success
```
### Rule 11: Existing heroes without incorrect credential can't register
```gherkin
When a hero called "Spider-man" tries to register with the key "badKey"
Then the registration is forbidden
```

### Rule 12: Unknown heroes can't register
```gherkin
When a hero called "Ukuleleman" tries to register with the key "983cc61a-5efb-4733-ac63-3956c296a99f"
Then the registration is forbidden
```

### Rule 13: Villains can't log in
```gherkin
When a hero called "Gorilla Grodd" tries to register with the key "983cc61a-5efb-4733-ac63-3956c296a99f"
Then the registration is forbidden
```

### Rule 14: You can register a neutral Hero
```gherkin
When a hero called "Floyd Lawton" tries to register with the key "23bb691d-d608-459a-b485-704dc0b73e65"
Then the registration is a success
```

### Rule 15: Hero with no alignment are considered neutral
```gherkin
When a hero called "Tricephalous" tries to register with the key "9c5cd16f-2b7c-4ee8-84a5-a76db7ae8826"
Then the registration is a success
```

### Rule 16: Can't register a fallen Hero
```gherkin
When a hero called "Jonathan Kent" tries to register with the key "9bd90bc0-4e8c-4dff-ba9a-0300452c88b3"
Then the registration is forbidden
```

## BONUS RULES:
### Rule 17: A hero can't have water and fire power, water is dominant

```gherkin
Given hero “Tricephalous” has Red Eyes
When powers are determined for "Tricephalous"
Then this hero has "Water" Power
Then this hero has no "Fire" Power
```
### Rule 17bis : Tricephalous can't prevent the meteorite because he has no Fire Power (can’t have both water and fire power)

```gherkin
Given these heroes registrations
| Name         |
| Tricephalous |
When these events occur
| Type      | Location |
| Meteorite | New York |
Then the intervention plan should be
| Hero         | Location | Action |
| Tricephalous | New York | Repair |
```

### Rule 18: Cannot have earth and air power, air is dominant
```gherkin
Given “Lasher” first appeared on May 1993
And Lasher is bald
When powers are determined for "Lasher" in the city of "Q"
Then this hero has no "Earth" Power

Explanation :
Q = 81
(1993 + 81) mod 17 = 0, divisible by 17, should have earth BUT
appeared in a month without R and bald so has Air, witch is dominant
```

## Rule 19: Hero Aang has all powers everywhere ;o)
```gherkin
When powers are determined for "Aang" in "Paris"
Then this hero has "Air" Power
Then this hero has "Earth" Power
Then this hero has "Fire" Power
Then this hero has "Water" Power
```

### Rule 20: Always prevent and repair the strongest events
Events have a hidden “strength” property

```gherkin
Given these heroes registrations
| Name             |
| Lasher           |
| Aquaria Neptunia |
When these events occur
| Type  | Location  | Strength |
| Flood | New York  | 20       |
| Flood | Paris     | 30       |
| Flood | Aquaville | 5        |
Then the intervention plan should be
| Hero             | Location | Action  |
| Aquaria Neptunia | Paris    | Prevent |
| Lasher           | New York | Repair  |
```
### Rule 20bis: Strength is the number of appearance of a character divided by ten low rounded

```gherkin
Given hero “Iceman” appeared 5 times
When strength is determined for "Iceman"
Then strength is 0

Given hero “Joseph Wilson” appeared 229 times
When strength is determined for "Joseph Wilson"
Then strength is 22
```
### Rule 21 : If the event cannot be prevented nor repaired, event strength * 2 of heroes must go the the place
```gherkin
Given these heroes registrations
| Name |
| ?    |
| ?    |
When these events occur
| Type      | Location |
| Meteorite | New York |
Then the intervention plan should be
| Hero  | Location |
| Azura | New York |


TODO:
* Team chart
* The oracle
* Game master
* More rules / fake events
