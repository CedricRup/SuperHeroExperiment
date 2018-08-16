# Emissary guide

## Your mission as facilitator:
Facilitate a safe environment for one or two teams that you are in charge of, answers theirs questions, getting needed information, so that they can reach their goals

Checklist before the hands-on
* A designated space/room for the team
* Wall spaces or flipcharts so that the team can use as a board with post-its
* Sets of Post-its and markers
* A way to show the slides
* Capacity to run the Oracle


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
.\gradlew runOracle -PteamName=theTeamName -Purl=theFullUrlOfYourTeamApi

```

You wll find the results in the oracle/testResults directory
