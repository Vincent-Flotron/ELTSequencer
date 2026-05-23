namespace ELTSequencer
{
    public class TransformCommand : ICommand
    {
        public bool Execute(ContextBag context)
        {
            try
            {
                // Example: Transform data from context
                if (context.ContainsKey("LoadedData"))
                {
                    context["TransformedData"] = $"Transformed: {context["LoadedData"]}";
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}