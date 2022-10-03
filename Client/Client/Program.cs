using System;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            class1.Connect();
            class1.SendMessage();
            class1.ReceiveMessage();
            class1.Disconnect();
        }
    }
}
