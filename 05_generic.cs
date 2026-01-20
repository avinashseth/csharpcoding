using System; // Import the Base Class Library
using System.Collections;

namespace day2 // Organize your code
{
    class Program // Everything lives in a Class
    {

        class MyGenericClassName<MyDataType>
        {
            private MyDataType myDataType;

            public MyGenericClassName(MyDataType myDataTypeValue)
            {
                myDataType = myDataTypeValue;
            }
            public void Display()
            {
                Console.WriteLine("Value: " + myDataType);
            }
        }

        static void Main()
        {
            MyGenericClassName<int> intObjectType = new MyGenericClassName<int>(100);
            intObjectType.Display();

            MyGenericClassName<string> stringObjectType = new MyGenericClassName<string>("Avinash Seth");
            stringObjectType.Display();
        }


    }
}
