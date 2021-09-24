namespace In_Class_Abstract_Class
{
    public abstract class Vehicle
    
    {
        public string Make { get; set; }

        public string Model { get; set; }

        public abstract void Drive();

        public virtual void Start()
        {
            System.Console.WriteLine("The Vehicle is running");
        }

        public void Stop()
        {
            System.Console.WriteLine("The Vehicle is stopped");
        }

        public abstract void RemoteStart();

        public virtual void Brake()
        {
            System.Console.WriteLine("The vehicle is braking!");
        }


    }
}
