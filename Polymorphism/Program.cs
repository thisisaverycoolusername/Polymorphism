namespace Polymorphism
{

    class Geometri 
    { 
        public virtual double Area()
        {
            return 0;
        }
        

    }
    class Rektangel : Geometri
    {
        public double längd { get; set; }
        public double bredd { get; set; }
        public Rektangel(double Längd, double Bredd )
        {
            längd = Längd;
            bredd = Bredd;
        }
        public override double Area()
        {
            return längd * bredd;
        }
    }
    class Fyrkant : Geometri
    {
        public double Sida { get; set; }

        public Fyrkant(double sida)
        {
            Sida = sida;
        }
        public override double Area()
        {
            return Sida* Sida;
        }
    }
    class Cirkel : Geometri
    {
        public double Radius { get; set; }

        public Cirkel(double radius)
        {
            Radius = radius;
        }
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
    class Parallelogram : Geometri
    {
        public double Bas { get; set; }
        public double Höjd { get; set; }
        public Parallelogram(double bas, double höjd)
        {
            Bas = bas;
            Höjd = höjd;
        }
        public override double Area()
        {
            return Bas * Höjd;
        }
    }
    class Ellips : Geometri
    {
        public double AxisA { get; set; }
        public double AxisB { get; set; }
        public Ellips(double axisA,double axisB)
        {
            AxisA = axisA;
            AxisB = axisB;
        }
        public override double Area()
        {
            return Math.PI * AxisA * AxisB;
        }
    }
    internal class Program

    {
        static void Main(string[] args)
        {
            Geometri[] former = new Geometri[5];

            former[0] = new Rektangel(4, 6);
            former[1] = new Fyrkant(5);
            former[2] = new Cirkel(3);
            former[3] = new Parallelogram(4, 4);
            former[4] = new Ellips(4, 8);


            foreach (var form in former)
            {
                Console.WriteLine($"Area: {form.Area()}");
            }
        }
    }
}