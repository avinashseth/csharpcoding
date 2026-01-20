using System; // Import the Base Class Library
using System.Collections;

namespace __CHANGE_HERE__ // Organize your code
{
    class Program // Everything lives in a Class
    {

        static void Main(string[] args) // The Entry Point
        {

            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add("Hello");
            list.Add(3.14);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }
    }
}
