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
            SequencerInvoker.AddCommand(new TransformCommand());

            // Execute all commands
            SequencerInvoker.ExecuteCommands(context);

            Console.WriteLine("Commands executed. Check command_log.txt for details.");
        }
    }
}