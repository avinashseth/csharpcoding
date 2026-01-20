class Program
{
    class Father
    {
        private string firstName = "Ashok";
        protected string lastName = "Seth";

    }

    class Child : Father
    {

        private string myName = "Avinash";

        public void DisplayFullName()
        {
            Console.WriteLine("Full Name: " + myName + " " + lastName); // This will cause a compile-time error
        }
    }


    public static void Main(string[] args)
    {
        Child avinash = new Child();
        avinash.DisplayFullName();
    }

}
