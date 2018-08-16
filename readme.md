# The Super Hero Experiment
## Main goals of the hands-on :

* Strengthen collaboration between different profiles (Dev, Ops, Testers, Security, Product Owners, Architects )
* Experiment new ways of working together (DevOps, Agile, Example Mapping)
* Test business/tech communication capabilities
* Test auto organization capabilities

## Logistics

The game requires a day to be run and debriefed.
Each team must have a separate space with a paper board/ white board.
It can be run with one facilitor for 2 teams of 10 players.


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

### Emissary guideline

See the [Emissary Guide](Emissary_Guide.md ) and [The Rules](The_Rules.md)
