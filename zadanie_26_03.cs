using System.Security.Cryptography.X509Certificates;

namespace zadanie_26_03
{

    class Prostopadloscian
    {
        public int sciana1 = Convert.ToInt32(Console.ReadLine());
        public int sciana2 = Convert.ToInt32(Console.ReadLine());
        public int sciana3 = Convert.ToInt32(Console.ReadLine());

        public void obliczenie_objetosci()
        {
            int V = sciana1 * sciana2 * sciana3;
            Console.WriteLine("Objętość: " + V);
        }
        public void obliczenie_powierzchni()
        {
            int S = 2 * sciana1 + 2 * sciana2 + 2 * sciana3;
            Console.WriteLine("Powierzchnia: " + S);
        }
        public void obliczenie_krawedzi()
        {
            int krawedz = 4 * sciana1 + 4 * sciana2 + 4 * sciana3;
            Console.WriteLine("Długość wszystkich krawędzi: " + krawedz);
        }


        public void obliczenia()
        {
            obliczenie_objetosci();
            obliczenie_powierzchni();
            obliczenie_krawedzi();
        }
    }

    class przeliczeniaSI
    {
        public double metry = Convert.ToDouble(Console.ReadLine());

        public void system_anglosaski()
        {
            Console.WriteLine(metry * 0.00062137);
        }
    }

    public class samochod
    {
        public static double mockW = Convert.ToInt32(Console.ReadLine());
        public static double Mech = Convert.ToInt32(Console.ReadLine());

        // mockW * 0,74 = konie mechaniczne

        public Func<double> MocWMech = delegate
        {
            return mockW * 0.74;
        };
        public Func<double> MechWMoc = delegate
        {
            return Mech / 0.74;
        };

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tZADANIE I\n");

            Console.WriteLine("Wpisz wartości boków: ");
            Prostopadloscian figura1 = new Prostopadloscian();
            figura1.obliczenia();

            Console.WriteLine("\n\n\tZADANIE II\n");

            Console.WriteLine("Wpisz znaczenie w metrach: ");
            przeliczeniaSI przeliczenie = new przeliczeniaSI();
            przeliczenie.system_anglosaski();

            Console.WriteLine("\n\n\tZADANIE III\n");
            Console.WriteLine("Wpisz moc samochodu w kW i w koniach mechaniznych: ");
            samochod Toyota = new samochod();
            Console.WriteLine("Kw w konie mechaniczne: " + Toyota.MocWMech());
            Console.WriteLine("Konie mechaniczne w Kw: " + Toyota.MechWMoc());


        }
    }
}
