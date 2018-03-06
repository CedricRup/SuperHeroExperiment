Feature: Super Hero Powers

  Background:
    Given this heroes may register
      | Name               | Eye         | Alive             | Appearances | First Appearance | Hair       | Sex                | Align              | Id              | Secret                               |
      | Iceman             |             | Living Characters | 5           | Jan-11           | Blond Hair | Male Characters    | Neutral Characters | Secret Identity | b364bbc2-261c-4da6-8a15-1dda2c92c9bb |
      | Charles Blackwater |             | Living Characters | 4           | Oct-91           |            | Male Characters    | Good Characters    | Secret Identity | a92b57f0-e6eb-43c6-ac53-2efcbec811e8 |
      | Aquaria Neptunia   | Blue Eyes   | Living Characters | 139         | May-47           | Blond Hair | Female Characters  | Good Characters    | Secret Identity | ccefd65a-0f7e-4a98-bffe-c6f9cc12ddd1 |
      | Cornfed            | Red Eyes    | Living Characters | 6           | Apr-05           | Blond Hair | Male Characters    | Good Characters    | Secret Identity | 07fc91d5-8d83-4ff4-8ad0-f5c1f81e421e |
      | Illich Lavrov      | Yellow Eyes | Living Characters | 5           | Oct-86           | Blond Hair | Male Characters    | Good Characters    | Secret Identity | d3db560c-49b2-4ea3-b996-86d9dce0998f |
      | Tricephalous       | Red Eyes    | Living Characters | 13          | Nov-61           | No Hair    | Male Characters    |                    | Secret Identity | 9c5cd16f-2b7c-4ee8-84a5-a76db7ae8826 |
      | Joseph Wilson      | Green Eyes  | Living Characters | 229         | 1984, May        | Blond Hair | Male Characters    | Neutral Characters | Secret Identity | c886982a-85de-4221-a28f-6616b32edadc |
      | Aleister Hook      | Red Eyes    | Living Characters | 7           | 1988, March      | White Hair | Male Characters    | Bad Characters     | Secret Identity | a534d762-0777-41d0-9571-eb8e5e021e29 |
      | Lasher             | White Eyes  | Living Characters | 14          | May-93           | Bald       | Agender Characters | Neutral Characters | Secret Identity | 37632ead-13a7-45e4-aea3-495562265699 |

  @ignore
  Scenario: A hero has Water power if her name has water, ice or Aqua in it
    When powers are determined for "Iceman"
    Then this hero has "Water" Power

    When powers are determined for "Charles Blackwater"
    Then this hero has "Water" Power

    When powers are determined for "Aquaria Neptunia"
    Then this hero has "Water" Power

    When powers are determined for "Fire Dragon"
    Then this hero has no "Water" Power

  @ignore
  Scenario: A hero has fire power if she has Red or Yellow eyes
    When powers are determined for "Cornfed"
    Then this hero has "Fire" Power

    When powers are determined for "Illich Lavrov"
    Then this hero has "Fire" Power

  @ignore
  Scenario: A hero can't have water and fire power, water is dominant

    When powers are determined for "Tricephalous"
    Then this hero has "Water" Power
    Then this hero has no "Fire" Power

  @ignore
  Scenario: Strenght is the number of appearence of a character divided by ten low rounded
    When strenght is determined for "Iceman"
    Then strength is 0

    When strenght is determined for "Joseph Wilson"
    Then strength is 22

  @ignore
  Scenario: A hero has earth power on a place if year of appearance + sum of ascii code of location is divisible by 17
    When powers are determined for "Aleister Hook" in "Paris"
    Then this hero has "Earth" Power

    When powers are determined for "Aleister Hook" in "Parit"
    Then this hero has no "Earth" Power

  @ignore
  Scenario: A hero has air power if he is bald and first appeared on a month withtout an "r" in it
    When powers are determined for "Lasher" in "Paris"
    Then this hero has "Air" Power

  @ignore
  Scenario: Cannot have earth and air power, air in dominant
    When powers are determined for "Lasher" in "Q"
    Then this hero has no "Earth" Power

  @ignore
  Scenario: Aang has all powers everywhere ;o)
    When powers are determined for "Aang" in "Paris"
    Then this hero has "Air" Power
    Then this hero has "Earth" Power
    Then this hero has "Fire" Power
    Then this hero has "Water" Power

