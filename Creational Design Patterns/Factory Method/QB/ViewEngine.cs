namespace Factory_Method
{
    public interface ViewEngine
    {
        string render(string viewName, Dictionary<string, object> context);
    }
}