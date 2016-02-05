Feature: AlarmClock
	In order to avoid short morning breakfast and shower times
	As a sleepy guy
	I want to set a remote clock alarm to ring in my PC

@mytag
Scenario: Set an new alarm clock
	Given I have a new alarm to register
	When I submit my new alarm
	Then the computer must ring at the alarm set time
