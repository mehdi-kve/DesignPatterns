public abstract class Handler
{
    private Handler _nextHandler;

    public Handler(Handler next)
    {
        this._nextHandler = next;
    }

    public void Handle(HttpRequest request)
    {
        // true : has finishied
        // false: has not finished yet

        if (doHandle(request))
            return;

        // to check if next handler is null

        if (_nextHandler != null)
            _nextHandler.Handle(request);
    }

    public abstract bool doHandle(HttpRequest request);
}