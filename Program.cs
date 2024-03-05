namespace Plane
{
    public interface IPlane
    {
        string Airline { get; set; }
        int Type { get; set; }
        int Range { get; set; }

        double Speed(double distance, double hours);
        string Display(double d, double h);
    }

    internal class Program
    {
        class Airbus : IPlane
        {
            public string Airline { get; set; }
            public int Type { get; set; }
            public int Range { get; set; }

            public Airbus()
            {
                Airline = string.Empty;
                Type = 0;
                Range = 0;
            }
            public Airbus(string airline, int type, int range)
            {
                Airline = airline;
                Type = type;
                Range = range;
            }

            public double Speed(double distance, double hours)
            {
                return distance / hours;
            }
            public string Display(double d, double h)
            {
                return $" Plane Information\n Type: A{Type} (Airbus)\n Airline: {Airline}\n Speed: {Speed(d,h)} km/h\n Range: {Range} km";
            }
        }

        static void Main(string[] args)
        {
            Airbus air = new Airbus("Delta", 359, 15001);
            Console.WriteLine("What is the distance the plane flew?(km): ");
            double distance = double.Parse(Console.ReadLine());
            Console.WriteLine("How many hours was the flight?: ");
            double hours = double.Parse(Console.ReadLine());
            Console.WriteLine("\n*-------------------------*");
            Console.WriteLine($"{air.Display(distance, hours)}");
            Console.WriteLine("*-------------------------*");
        }
    }
}
