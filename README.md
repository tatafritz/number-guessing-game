# Number Guessing Game

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Learning Project](https://img.shields.io/badge/Learning%20Project-FFCA28?style=for-the-badge)

This is a simple command-line number guessing game I built using C#, my primary programming language.

I decided to build this project to practice some C# fundamentals and strengthen my programming logic. I wanted to work through the problem myself without relying on AI to write the code for me, using my own notes only when I needed to review something.

The goal was to keep the project simple while giving myself an opportunity to practice things like conditionals, loops, variables, user input, `switch` statements, random number generation, and input validation.

**Game logic:** The player chooses a difficulty level, and the game generates a random number within a range determined by the selected difficulty. The player then has a limited number of attempts to guess the correct number.

## Features

* Three difficulty levels with:

  * Different number ranges
  * Different attempt limits
* Random number generation (of course, haha)
* Input validation using `int.TryParse`

  * At the game menu: validates whether the selected option is between `1` and `3` (the currently available difficulty levels)
  * During the game: invalid inputs, such as letters or other non-numeric values, are rejected without consuming attempts
* Feedback for incorrect and correct guesses
* Displays the correct number when all attempts are used

## Difficulty Levels

| Level | Difficulty | Number Range | Attempts |
| ----: | ---------- | ------------ | -------: |
|     1 | Easy       | 0 to 10      |        5 |
|     2 | Medium     | 0 to 50      |        7 |
|     3 | Hard       | 0 to 100     |       10 |

## How to Play

1. Run the application.
2. Choose a difficulty level by entering `1`, `2`, or `3`.
3. The game generates a random number within the selected range.
4. Enter a number to make a guess.
5. If the guess is incorrect, the game lets you try again while attempts remain.
6. The game ends when you guess the correct number or use all available attempts.

## Technologies

* C#
* .NET
* Console Application

## How to Run

### Clone the Repository

Clone the repository using Git:

```bash
git clone https://github.com/tatafritz/number-guessing-game
```

Navigate to the project directory:

```bash
cd number-guessing-game
```

Run the application:

```bash
dotnet run
```

### Requirements

* .NET SDK
* Git

## What's Next

I want to keep improving this project as I learn more C# and programming concepts. Some of the things I plan to work on next are:

* [ ] Add a replay option so the player can start a new game without restarting the application
* [ ] Add hints by telling the player whether their guess is higher or lower than the generated number
* [ ] Add a scoring system based on difficulty and remaining attempts
* [ ] Add basic game statistics, such as games played, wins, and losses
* [ ] Refactor the code into separate methods as the project grows
* [ ] Improve the overall CLI experience and user feedback