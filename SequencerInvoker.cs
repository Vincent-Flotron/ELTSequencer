namespace ELTSequencer
{
    // SequencerInvoker: Executes a list of commands in sequence
    public class SequencerInvoker
    {
        private readonly List<ICommand> _commands = new List<ICommand>();

        public void AddCommand(ICommand command)
        {
            _commands.Add(command);
        }

        public void ExecuteCommands(ContextBag context)
        {
            foreach (var command in _commands)
            {
                bool success = command.Execute(context);
                FileLogger.Log($"{command.GetType().Name} executed: {(success ? "SUCCESS" : "FAILURE")}");
            }
        }
    }
}