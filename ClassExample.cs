class Program
{
    class Human
    {

        string fullName = "Avinash Seth";

        public string getFullName()
        {
            return fullName;
        }

    }

    public static void Main(string[] args)
    {
        Human avinash = new Human();
        Console.WriteLine(avinash.getFullName());
    }

}
