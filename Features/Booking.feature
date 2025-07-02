Feature: As a user, I want to be able to select a room and book it, so that I can stay at the accommodation.

  @smoke
  Scenario: Book a room successfully
    Given the booking service is available
    When the user provides valid room and guest details
    Then the booking should be successful
