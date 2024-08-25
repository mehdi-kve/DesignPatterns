namespace Momento;

class Program
{
    static void Main(string[] args)
    {
        var history = new History();

        var editor = new Editor();
        editor.content = "a";
        history.push(editor.creatState());  

        editor.content = "b";
        history.push(editor.creatState());

        editor.content = "c";
        editor.restore(history.pop());

        Console.WriteLine(editor.content);

    }
}
