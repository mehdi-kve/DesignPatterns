namespace Mediator_Pattern;

class Program
{
    static void Main(string[] args)
    {
        var listBox = new ListBox();
        var button = new Button();
        var textBox = new TextBox();
        var dialog = new ArticleDialogBox(listBox, textBox, button);
        dialog.simulateUserInteraction();
    }
}
