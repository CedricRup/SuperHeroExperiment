Feature: Bonus Rules

  Background:
    Given this heroes may register
      | Name             | Eye        | Alive             | Appearances | First Appearance | Hair       | Sex                | Align              | Id              | Secret                               |
      | Aquaria Neptunia | Blue Eyes  | Living Characters | 139         | May-47           | Blond Hair | Female Characters  | Good Characters    | Secret Identity | ccefd65a-0f7e-4a98-bffe-c6f9cc12ddd1 |
      | Tricephalous     | Red Eyes   | Living Characters | 13          | Nov-61           | No Hair    | Male Characters    |                    | Secret Identity | 9c5cd16f-2b7c-4ee8-84a5-a76db7ae8826 |
      | Lasher           | White Eyes | Living Characters | 14          | May-93           | Bald       | Agender Characters | Neutral Characters | Secret Identity | 37632ead-13a7-45e4-aea3-495562265699 |

  @bonus
  Scenario: Always prevent and repair the strongest events
    Given these heroes registrations
      | Name             |
      | Lasher           |
      | Aquaria Neptunia |
    When these events occur
      | Type    | Location  | Strength |
      | Tsunami | New York  | 20       |
      | Tsunami | Paris     | 30       |
      | Tsunami | Aquaville | 5        |
    Then the intervention plan should be
      | Hero             | Location | Action  |
      | Aquaria Neptunia | Paris    | Prevent |
      | Lasher           | New York | Repair  |

  @bonus
  Scenario: Tricephalous can't prevent the meteorite because he has no Fire Power
    Given these heroes registrations
      | Name         |
      | Tricephalous |
    When these events occur
      | Type      | Location |
      | Meteorite | New York |
    Then the intervention plan should be
      | Hero         | Location | Action |
      | Tricephalous | New York | Repair |


  @bonus
  @ignore
  Scenario: If the event cannot be prevented nor repaired, event strength * 2 of heroes must go the the place
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




