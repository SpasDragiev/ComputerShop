# ComputerShop

Simple console application that reads customer computer configurations and prints summary statistics.

Requirements
- .NET 10 SDK

Build
- Using Visual Studio: open ComputerShop.slnx and build the solution.
- Using CLI: run `dotnet build` in the project directory.

Run
- From CLI: `dotnet run --project ComputerShop.csproj` or run the built executable.

Input format
- The program reads lines from standard input. Enter customer records one per line in the format:
  Name/Videocard,Processor,SSD
- Terminate customer input with a line containing: `End`
- After that, enter a single line with a characteristic to search for (videocard name, processor name, or SSD size).

Example
```
Peter/RTX3080,Intel i7,512
Maria/GTX1660,AMD Ryzen 5,256
End
RTX3080
```

Output
- Prints total customers, counts by videocard, processor, and SSD size, and lists customers that match the given characteristic.

Project files
- Program.cs — main program logic
- Customer.cs — customer model and parsing
- Computer.cs — computer model

License
- MIT

