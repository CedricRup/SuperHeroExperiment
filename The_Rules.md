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
* Rule 11: A hero has Air power if he is bald and first appeared on a month without an "r" in it

## SECURITY
* Rule 12: Existing heroes without incorrect credential can't register
* Rule 13: Unknown heroes can't register
* Rule 14: Villains can't log in
* Rule 15: You can register a neutral Hero
* Rule 16: Hero with no alignment are considered neutral
* Rule 17: Can't register a fallen Hero

## BONUS
* Rule 18: A hero can't have water and fire power, water is dominant
* Rule 19: Cannot have earth and air power, air is dominant
* Rule 20: Hero Aang has all powers everywhere ;o)
* Rule 21: Always prevent and repair the strongest events
* Rule 22 : If the event cannot be prevented nor repaired, event strength * 2 of heroes must go the the place

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

### Rule 12: Existing heroes with the correct credential can register
```gherkin
When a hero called "Spider-man" tries to register with the key "7effb551-5364-48cb-9014-a36fd7068619"
Then the registration is a success
```
### Rule 13: Existing heroes without incorrect credential can't register
```gherkin
When a hero called "Spider-man" tries to register with the key "badKey"
Then the registration is forbidden
```

### Rule 12: Unknown heroes can't register
```gherkin
When a hero called "Ukuleleman" tries to register with the key "983cc61a-5efb-4733-ac63-3956c296a99f"
Then the registration is forbidden
```

### Rule 14: Villains can't log in
```gherkin
When a hero called "Gorilla Grodd" tries to register with the key "983cc61a-5efb-4733-ac63-3956c296a99f"
Then the registration is forbidden
```

### Rule 15: You can register a neutral Hero
```gherkin
When a hero called "Floyd Lawton" tries to register with the key "23bb691d-d608-459a-b485-704dc0b73e65"
Then the registration is a success
```

### Rule 16: Hero with no alignment are considered neutral
```gherkin
When a hero called "Tricephalous" tries to register with the key "9c5cd16f-2b7c-4ee8-84a5-a76db7ae8826"
Then the registration is a success
```

### Rule 17: Can't register a fallen Hero
```gherkin
When a hero called "Jonathan Kent" tries to register with the key "9bd90bc0-4e8c-4dff-ba9a-0300452c88b3"
Then the registration is forbidden
```

## BONUS RULES:
### Rule 18: A hero can't have water and fire power, water is dominant

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

### Rule 19: Cannot have earth and air power, air is dominant
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

## Rule 20: Hero Aang has all powers everywhere ;o)
```gherkin
When powers are determined for "Aang" in "Paris"
Then this hero has "Air" Power
Then this hero has "Earth" Power
Then this hero has "Fire" Power
Then this hero has "Water" Power
```

### Rule 21: Always prevent and repair the strongest events
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
### Rule 21bis: Strength is the number of appearance of a character divided by ten low rounded

```gherkin
Given hero “Iceman” appeared 5 times
When strength is determined for "Iceman"
Then strength is 0

Given hero “Joseph Wilson” appeared 229 times
When strength is determined for "Joseph Wilson"
Then strength is 22
```
### Rule 22 : If the event cannot be prevented nor repaired, event strength * 2 of heroes must go the the place
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
```
