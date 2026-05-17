# Hangman Game

A simple Hangman game built using C# and Object-Oriented Programming principles.


## Overview

This project is a Hangman game developed in C#.  
The player tries to guess a hidden word letter by letter before running out of attempts.

The game also optionally connects to an ESP32 device using serial communication to display game updates externally.


## Features

- Word guessing system with hidden letters
- Tracks correct and incorrect guesses
- Difficulty levels (Easy / Medium / Hard)
- Visual Hangman ASCII art
- Win/Lose conditions
- Optional ESP32 serial communication support


## Classes Used

### `Word`
Handles the secret word, guesses, and display logic.

### `Player`
Takes and validates user input (single-letter guesses).

### `Game`
Controls:
- Main game loop
- Difficulty selection
- Game logic
- ESP32 communication

### `Program`
Starts the game and manages ESP32 connection setup.


## How to Play

1. Run the program
2. Select a difficulty level
3. Guess letters one by one
4. Complete the word before reaching 6 mistakes


## ESP32 Integration (Optional)

If an ESP32 is connected, the game can:

- Display the current word state (For Easy Levels Only)
- Show the number of mistakes
- Display win/lose messages

If no ESP32 is connected, the game runs normally in terminal-only mode.


## How to Run

1. Open the project in Visual Studio, VS Code, or any C# IDE
2. Build the solution
3. Run the program
4. *(Optional)* Connect ESP32 via `COM3` at `115200` baud rate


## Technologies Used

- C#
- .NET
- Object-Oriented Programming
- ESP32
- Serial Communication (`System.IO.Ports`)
