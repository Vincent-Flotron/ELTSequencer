namespace ELTSequencer
{
    public class TransformCommand : ICommand
    {
        private readonly string _sqlFilePath;

        public TransformCommand(string sqlFilePath)
        {
            _sqlFilePath = sqlFilePath;
        }

        public bool Execute(ContextBag context)
        {
            try
            {
                if (context.ContainsKey("LoadedData"))
                {
                    // Simulate executing the SQL file
                    string transformedData = $"Transformed with {_sqlFilePath}: {context["LoadedData"]}";
                    context["TransformedData"] = transformedData;
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