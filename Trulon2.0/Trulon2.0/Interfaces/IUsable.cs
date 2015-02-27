namespace Trulon.Interfaces
{
    public interface IUsable
    {
        int Countdown { get; set; }

        bool HasTimedOut { get; set; }
    }
}
