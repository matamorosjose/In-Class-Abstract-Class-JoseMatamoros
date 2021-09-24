using System;

namespace In_Class_Abstract_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Ford ford = new Ford();
            ford.RemoteStart();
            ford.Drive();
            ford.Stop();

            System.Console.WriteLine("\n");

            Subaru subaru = new Subaru();
            subaru.RemoteStart();
            subaru.Drive();
            subaru.Stop();

        }
    }
}
