public class EmailService
{
    public void Send(string msg)
    {
        Console.WriteLine($"Email sent: {msg}");
    }
}

// The Business Logic
public class MedicineTracker
{
    private EmailService _email = new EmailService();

    public void CheckExpiry()
    {
        // ... logic to find expired meds ...
        _email.Send("Your Paracetamol is expiring!");
    }
}

class Program
{

    static void Main()
    {

        MedicineTracker mt = new MedicineTracker();
        mt.CheckExpiry();

    }

}
