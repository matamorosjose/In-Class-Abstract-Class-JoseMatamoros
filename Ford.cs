namespace In_Class_Abstract_Class
{
    public class Ford : Vehicle
    {

    public string color {get; set;}

    public override void Drive()
        {
            System.Console.WriteLine("The Vehicle is Driving");
        }

        public override void RemoteStart()
        {
            System.Console.WriteLine("The Vehicle has been remotely started");
        }  

    }
    

}