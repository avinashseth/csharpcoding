namespace MVCExample.Models
{
    // --- THIS IS THE MODEL ---
    // It represents the 'Data' or 'Object' our application works with.
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool CanVote { get; set; }
    }
}
