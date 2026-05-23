
namespace ELTSequencer
{
    public class ExtractCommand : ICommand
    {
        public bool Execute(ContextBag context)
        {
            try
            {
                // Example: Extract data and store in context
                context["ExtractedData"] = "Sample Data";
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}