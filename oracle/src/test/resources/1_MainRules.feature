Feature: Main Rules

  Background:
    Given this heroes may register
      | Name               | Eye         | Alive             | Appearances | First Appearance | Hair       | Sex                | Align              | Id                                   | Secret                               |
      | Iceman             |             | Living Characters | 5           | Jan-11           | Blond Hair | Male Characters    | Neutral Characters | Secret Identity                      | b364bbc2-261c-4da6-8a15-1dda2c92c9bb |
      | Charles Blackwater |             | Living Characters | 4           | Oct-91           |            | Male Characters    | Good Characters    | Secret Identity                      | a92b57f0-e6eb-43c6-ac53-2efcbec811e8 |
      | Aquaria Neptunia   | Blue Eyes   | Living Characters | 139         | May-47           | Blond Hair | Female Characters  | Good Characters    | Secret Identity                      | ccefd65a-0f7e-4a98-bffe-c6f9cc12ddd1 |
      | Cornfed            | Red Eyes    | Living Characters | 6           | Apr-05           | Blond Hair | Male Characters    | Good Characters    | Secret Identity                      | 07fc91d5-8d83-4ff4-8ad0-f5c1f81e421e |
      | Illich Lavrov      | Yellow Eyes | Living Characters | 5           | Oct-86           | Blond Hair | Male Characters    | Good Characters    | Secret Identity                      | d3db560c-49b2-4ea3-b996-86d9dce0998f |
      | Aleister Hook      | Red Eyes    | Living Characters | 7           | 1988, March      | White Hair | Male Characters    | Bad Characters     | Secret Identity                      | a534d762-0777-41d0-9571-eb8e5e021e29 |
      | Lasher             | White Eyes  | Living Characters | 14          | May-93           | Bald       | Agender Characters | Neutral Characters | Secret Identity                      | 37632ead-13a7-45e4-aea3-495562265699 |
      | Mara Rice          |             | Living Characters | 1           | May-40           | Black Hair | Female Characters  | Good Characters    | Public Identity                      | 7fc204ac-fe4d-4cb3-b9ae-54d774525a22 |
      | Ella Pinkwater     |             | Living Characters | 2           | mars-91          | Blond Hair | Female Characters  | Neutral Characters |                                      |185645c4-1664-46cc-96f4-afe39c53e931  |

  @main
  Scenario: When nothing happens, everybody should be in standby in the Batcave
    Given these heroes registrations
      | Name             |
      | Aquaria Neptunia |
      | Iceman           |
    Then the intervention plan should be
      | Hero             | Location | Action  |
      | Aquaria Neptunia | Batcave  | Standby |
      | Iceman           | Batcave  | Standby |

  @main
  Scenario: When the end of mission event is signaled, no hero is available
    Given these heroes registrations
      | Name             |
      | Aquaria Neptunia |
      | Iceman           |
    When these events occur
      | Type           | Location |
      | End Of Mission | Secret   |
    Then the intervention plan should be empty

  @main
  Scenario: You can prevent a Tsunami with Water (aqua)
    Given these heroes registrations
      | Name             |
      | Aquaria Neptunia |
    When these events occur
      | Type    | Location |
      | Tsunami | New York |
    Then the intervention plan should be
      | Hero             | Location | Action  |
      | Aquaria Neptunia | New York | Prevent |


  @main
  Scenario: You can prevent a Tsunami with Water (ice)
    Given these heroes registrations
      | Name      |
      | Mara Rice |
    When these events occur
      | Type    | Location |
      | Tsunami | New York |
    Then the intervention plan should be
      | Hero      | Location | Action  |
      | Mara Rice | New York | Prevent |

  @main
  Scenario: You can prevent a Tsunami with Water (water)
    Given these heroes registrations
      | Name           |
      | Ella Pinkwater |
    When these events occur
      | Type    | Location |
      | Tsunami | New York |
    Then the intervention plan should be
      | Hero           | Location | Action  |
      | Ella Pinkwater | New York | Prevent |

  @main
  Scenario: You need Air to repair a Tsunami
    Given these heroes registrations
      | Name   |
      | Lasher |
    When these events occur
      | Type    | Location |
      | Tsunami | New York |
    Then the intervention plan should be
      | Hero   | Location | Action |
      | Lasher | New York | Repair |

  @main
  Scenario: No need to repair if you can prevent
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

  @main
  Scenario: You need Fire to prevent a meteorite
    Given these heroes registrations
      | Name    |
      | Cornfed |
    When these events occur
      | Type      | Location |
      | Meteorite | New York |
    Then the intervention plan should be
      | Hero    | Location | Action  |
      | Cornfed | New York | Prevent |

  @main
  Scenario: If a meteorite can't be prevented, a water able hero must be send
    Given these heroes registrations
      | Name             |
      | Aquaria Neptunia |
    When these events occur
      | Type      | Location |
      | Meteorite | New York |
    Then the intervention plan should be
      | Hero             | Location | Action |
      | Aquaria Neptunia | New York | Repair |


