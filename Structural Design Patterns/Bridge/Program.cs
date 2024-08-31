namespace Bridge;

class Program
{
    static void Main(string[] args)
    {
        var remoteControl = new RemoteControl(new SonyTV());
        remoteControl.turnOn();
        remoteControl.turnOff();

        var advancedRemoteControl = new AdvancedRemoteControl(new LgTV());
        advancedRemoteControl.setChannel(13);
    }
}
