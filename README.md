# The Greeter Kata

## Code Katas
In software we do our practicing on the job, and that’s why we make mistakes on the job. We need to find ways of splitting the practice from the profession. We need practice sessions.


Code Kata is an attempt to bring this element of practice to software development. A kata is an exercise in karate where you repeat a form many, many times, making little improvements in each.   
**_&mdash;Dave Thomas, Agile Manifestor Co-Author and Author of The Pragmatic Programmer_**  
From Dave Thomas' [Code Kata site](http://codekata.com/).

## The Exercise
Today we'll be working on a code kata called the Greeter Kata that has been customized for the exercise. The intent of this kata is to give the team an opportunity to get a feel for the Test-Driven Development (TDD) workflow without dealing with the challenges of a large scale codebase that was not written test-first. It will incrementally introduce some common challenges and approaches for dealing with them. 

## The Greeter Feature
Upon logging into ACME Online Systems a user will be greeted. The greeting will provide a personlized welcome message.

## Acceptance Criteria
1. Given a name of the current user welcome them to the system via a message (with correct name capitalization)
2. Adjust the message based on the time of day in the current timezone
   * 5am - 12pm - provide a morning message
   * 12pm - 5pm - provide an afternoon message
   * 5pm - 7pm - provide an evening message
   * 7pm - 5am - provide a night message
3. Display a birthday message on the user's birthday - Append to the greeting _"have a great birthday!"_
4. Display the user's age in the birthday message
5. Display a random quote each time the user logs in

## Instructions
The boilerplate and first failing test are present.
The interface IGreeter and the class Greeter provide the functionality for the greeting.
The first failing test has been written, and is RED.

## The Three Rules of TDD
1. Just enough test code to fail (go red)
1. Just enough production code to pass (go green)
1. Only refactor when green

_**Now Repeat**_
