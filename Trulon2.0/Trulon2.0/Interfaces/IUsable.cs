namespace Trulon.Interfaces
{
    public interface IUsable
    {
        int Timeout { get; set; }

        int Countdown { get; set; }

        bool HasTimedOut { get; set; }
    }
}
