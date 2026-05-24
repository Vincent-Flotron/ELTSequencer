# ELTSequencer

A C# project implementing the **Command Pattern** to execute a sequence of ELT (Extract, Load, Transform) commands. Commands can pass data via a `ContextBag` and log their success or failure to both a file and email.

## Features

- **Command Pattern**: Uses an `Invoker` to execute a list of `ICommand` objects.
- **ContextBag**: A dictionary to pass data between commands.
- **Logging**:
  - **FileLogger**: Logs command execution results to `command_log.txt`.
  - **MailLogger**: Sends logs via email (configurable SMTP settings).

## Project Structure

- **Commands**:
  - `ExtractCommand`: Extracts data and stores it in the `ContextBag`.
  - `LoadCommand`: Loads data from the `ContextBag`.
  - `TransformCommand`: Transforms data using a specified SQL file.
- **Loggers**:
  - `FileLogger`: Writes logs to a file.
  - `MailLogger`: Sends logs via email.
- **Invoker**: Manages and executes the command sequence.

## How to Use

1. **Configure SMTP Settings** (for `MailLogger`):
  - Update `SmtpServer`, `SmtpPort`, `SmtpUsername`, `SmtpPassword`, `FromEmail`, and `ToEmail` in `MailLogger.cs`.
2. **Add Commands**:
  - Create instances of `ExtractCommand`, `LoadCommand`, and `TransformCommand` (with SQL file paths).
  - Add them to the `Invoker` in `Program.cs`.
3. **Run the Program**:
  - Execute the program. Logs will be written to `command_log.txt` and sent via email.

## Example

```csharp
var invoker = new Invoker();
var context = new ContextBag();

invoker.AddCommand(new ExtractCommand());
invoker.AddCommand(new LoadCommand());
invoker.AddCommand(new TransformCommand("sql1.sql"));
invoker.AddCommand(new TransformCommand("sql2.sql"));

invoker.ExecuteCommands(context);
```

## Requirements

- .NET 6.0 or later
- SMTP server access (for `MailLogger`)

## License

GNU GENERAL PUBLIC LICENSE Version 3
