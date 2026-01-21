// 1. The Interface (The "Contract")
public interface IMessageService
{
    void Send(string msg);
}
// 2. Multiple implementations
public class EmailService : IMessageService
{
    public void Send(string msg) => Console.WriteLine($"Email: {msg}");
}

public class SmsService : IMessageService
{
    public void Send(string msg) => Console.WriteLine($"SMS: {msg}");
}

// 3. The Logic (The "Constructor Injection")
public class MedicineTracker
{
    private readonly IMessageService _messageService;

    // We "Inject" the tool here. The class doesn't create it!
    public MedicineTracker(IMessageService service)
    {
        _messageService = service;
    }

    public void CheckExpiry()
    {
        _messageService.Send("Medicine expiring soon!");
    }
}

class Program
{

    static void Main(string[] args)
    {

        IMessageService emailService = new EmailService();

        MedicineTracker mt = new MedicineTracker(emailService);
        mt.CheckExpiry();

    }

}
