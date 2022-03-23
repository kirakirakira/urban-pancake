# Urban Pancake
Mystery game in C# for Code Louisville Software Development Course 1

## How To Run
This project uses .NET 6.0. To download the SDK: https://dotnet.microsoft.com/en-us/download/dotnet/6.0

You will also need the .NET CLI. https://docs.microsoft.com/en-us/dotnet/core/tools/

Recommend using VS Code: https://code.visualstudio.com/

There is a Makefile for this project. If you can't run a Makefile in Window's Command Prompt then use the full `dotnet` commands or you can ditch Windows here: https://ubuntu.com/download/desktop

1. Clone repo
1. Navigate to this project in the terminal.
1. From the parent directory:
    1. To restore dependencies: `make restore`
    1. To run: `make run`
    1. To run tests: `make test`

Windows:
1. To restore dependencies: `cd UrbanPancake` then `dotnet restore` (within UrbanPancake directory)
2. To run: `dotnet run --project UrbanPancake/UrbanPancake.csproj`
3. To run tests: `dotnet test UrbanPancake.LibraryTests/UrbanPancake.LibraryTests.csproj`

## Project Description
Someone's stolen some donuts from Miss Krumpet! It's your job to review the evidence and figure out who did it. Navigate through the menus to view and search the evidence data. Once you're ready to guess the thief, choose that selection from the main menu to see if you're the next Sherlock Holmes or not.
![Pink donut](pink_donut.jpg)

## Requirements Met
Minimum:
1. Create at least one class, then create at least one object of that class and populate it with data. You must use or display the data in your application.
1. Create and call at least 3 functions or methods, at least one of which must return a value that is used in your application.

Features:
1. Implement a “master loop” console application where the user can repeatedly enter commands/perform actions, including choosing to exit the program.
1. Read data from an external file, such as text, JSON, CSV, etc and use that data in your application.
1. Create 3 or more unit tests for your application.
1. Create an additional class which inherits one or more properties from its parent. (Used an interface)
1. Create a dictionary or list, populate it with several values, retrieve at least one value, and use it in your program.

## Next steps
Not all of the pieces of evidence have data or menus yet. Also, the data isn't fully populated and thus is not enough evidence for a fulfilling sleuthing experience. But the framework is set up and the creative part of developing the case and evidence is next.
