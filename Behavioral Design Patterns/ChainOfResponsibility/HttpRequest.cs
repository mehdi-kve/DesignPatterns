public class HttpRequest
{
    private string _username { get; set; }
    private string _password { get; set; }

    public HttpRequest(string usernaem, string password)
    {
        this._username = usernaem;
        this._password = password;
    }

    public string GetUsername()
    {
        return _username;
    }

    public string GetPassword()
    {
        return _password;
    }
}