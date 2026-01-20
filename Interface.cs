class Program
{
    interface IHuman
    {
        void getName();
        void getAge();

    }

    class Avinash : IHuman
    {
        private string name = "Rahul";
        private int age = 200;

        public void getName()
        {

            Console.WriteLine("My name is: " + name);

        }

        public void getAge()
        {

            Console.WriteLine("My age is: " + age);

        }

    }



    static void Main(string[] args) // The Entry Point
    {

        Avinash avinash = new Avinash();
        avinash.getName();
        avinash.getAge();

    }


}
