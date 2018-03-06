Feature: Security Rules

  Background:

    Given this heroes may register
      | Name            | Secret                               | Align              | Alive               |
      | Spider-man      | 7effb551-5364-48cb-9014-a36fd7068619 | Good Characters    | Living Characters   |
      | Gorilla Grodd   | 983cc61a-5efb-4733-ac63-3956c296a99f | Bad Characters     | Living Characters   |
      | Floyd Lawton    | 23bb691d-d608-459a-b485-704dc0b73e65 | Neutral Characters | Living Characters   |
      | Theodore Knight | 9bd90bc0-4e8c-4dff-ba9a-0300452c88b3 | Good Characters    | Deceased Characters |
      | Tricephalous    | 9c5cd16f-2b7c-4ee8-84a5-a76db7ae8826 |                    | Living Characters   |

  @security
  Scenario: Existing heroes with the correct credential can register
    When a hero called "Spider-man" tries to register with the key "7effb551-5364-48cb-9014-a36fd7068619"
    Then the registration is a success

  @security
  Scenario: Existing heroes without incorrect credential can't register
    When a hero called "Spider-man" tries to register with the key "badKey"
    Then the registration is forbidden

  @security
  Scenario: Unknown heroes can't register
    When a hero called "Ukuleleman" tries to register with the key "983cc61a-5efb-4733-ac63-3956c296a99f"
    Then the registration is forbidden

  @security
  Scenario: Villains can't log in
    When a hero called "Gorilla Grodd" tries to register with the key "983cc61a-5efb-4733-ac63-3956c296a99f"
    Then the registration is forbidden

  @security
  Scenario: You can register a neutral Hero
    When a hero called "Floyd Lawton" tries to register with the key "23bb691d-d608-459a-b485-704dc0b73e65"
    Then the registration is a success

  @security
  Scenario: Hero with no alignement are considered neutral
    When a hero called "Tricephalous" tries to register with the key "9c5cd16f-2b7c-4ee8-84a5-a76db7ae8826"
    Then the registration is a success

  @security
  Scenario: Can't register a fallen Hero
    When a hero called "Theodore Knight" tries to register with the key "9bd90bc0-4e8c-4dff-ba9a-0300452c88b3"
    Then the registration is forbidden


