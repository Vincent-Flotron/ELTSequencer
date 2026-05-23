
namespace ELTSequencer
{
    // ICommand: Interface for all commands
    public interface ICommand
    {
        bool Execute(ContextBag context);
    }
}