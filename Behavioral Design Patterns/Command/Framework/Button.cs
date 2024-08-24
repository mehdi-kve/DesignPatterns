namespace CommandAction.Framework
{
    public class Button
    {
        private string label = string.Empty;
        private Command command;

        public Button(Command command)
        {
            this.command = command;
        }

        public void click()
        {
            command.Execute();
        }

        public string getLabel()
        {
            return label;
        }

        public void setLabel(string label)
        {
            this.label = label;
        }
    }

}
