namespace ELTSequencer
{
    public class LoadCommand : ICommand
    {
        public bool Execute(ContextBag context)
        {
            try
            {
                if (context.ContainsKey("ExtractedData"))
                {
                    context["LoadedData"] = context["ExtractedData"];
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