using System;
using System.Collections.Generic;
using System.IO;

namespace ELTSequencer
{

    // Program: Demonstrates the usage
    class Program
    {
        static void Main()
        {
            var SequencerInvoker = new SequencerInvoker();
            var context = new ContextBag();

            // Add commands to the SequencerInvoker
            SequencerInvoker.AddCommand(new ExtractCommand());
            SequencerInvoker.AddCommand(new LoadCommand());
            
            SequencerInvoker.AddCommand(new TransformCommand("sql1.sql"));
            SequencerInvoker.AddCommand(new TransformCommand("sql2.sql"));
            SequencerInvoker.AddCommand(new TransformCommand("sql3.sql"));

            // Execute all commands
            SequencerInvoker.ExecuteCommands(context);

            Console.WriteLine("Commands executed. Check command_log.txt for details.");
            FileLogger.Log("Commands executed. Check command_log.txt for details.");
        }
    }
}