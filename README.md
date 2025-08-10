# Hangman

One of the first learning projects.  
A classic CLI text-based game of hangman where you need to guess the word before your lives run out.

## Install and Run

1. Install [.NET](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) 8.0 or higher.

2. Clone the repository:

    ```bash
	git clone https://github.com/UnLuckyNikolay/hangman
    cd hangman
	```

3. Build and run:

	```bash 
	dotnet build 
	dotnet run
	```

## How to Play

Choose the amount of lives and try to guess a random word.  
Some "words" are combinations of multiple words or obscure references.
The full list is located in `Program.cs` at line 13 if you wish to check/change it.

## What This Demonstrates

 * Basic C# syntax
 * Simple game loop
 * User input validation

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.