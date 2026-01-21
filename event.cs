using System;

// 1. The Publisher (The one who sends the alert)
public class AlarmClock
{
    // The Event (The Bell)
    public event Action OnAlarmRinging;

    public void Start()
    {
        Console.WriteLine("Alarm is counting down...");
        // 2. Triggering the Event (Ringing the Bell)
        OnAlarmRinging?.Invoke();
    }
}

class Program
{
    static void Main()
    {
        AlarmClock myClock = new AlarmClock();

        // 3. The Subscriber (What happens when the bell rings)
        myClock.OnAlarmRinging += () => Console.WriteLine("Wake up! It's time for college!");

        myClock.Start();
    }
}
