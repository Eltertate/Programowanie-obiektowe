using System;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;

namespace Wykresy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //tworzenie funkcji przykładowej (przy pierwszym odpalaniu programu)
            InitializeComponent();
            cartesianChart1.Series = new LiveCharts.SeriesCollection()
            {
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    {
                        new ObservablePoint(-10,-10),
                        new ObservablePoint(-3,-2),
                        new ObservablePoint(0,0),
                        new ObservablePoint(1,6),
                        new ObservablePoint(7,6),
                        new ObservablePoint(10,8)
                    },
                    PointGeometrySize = 15
                },
                new LineSeries
                {

                    Values = new ChartValues<ObservablePoint>
                    {
                        new ObservablePoint(-10,100),
                        new ObservablePoint(-9,81),
                        new ObservablePoint(-8,64),
                        new ObservablePoint(-7,49),
                        new ObservablePoint(-6,35),
                        new ObservablePoint(-5,25),
                        new ObservablePoint(-4,16),
                        new ObservablePoint(-3,9),
                        new ObservablePoint(-2,4),
                        new ObservablePoint(-1,1),
                        new ObservablePoint(0,0),
                        new ObservablePoint(1,1),
                        new ObservablePoint(2,4),
                        new ObservablePoint(3,9),
                        new ObservablePoint(4,16),
                        new ObservablePoint(5,25),
                        new ObservablePoint(6,36),
                        new ObservablePoint(7,49),
                        new ObservablePoint(8,64),
                        new ObservablePoint(9,81),
                        new ObservablePoint(10,100)
                    },
                    PointGeometrySize = 15
                }
            };
        }

        private void cartesianChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // pobieranie znaczenia o stopniach
            double stopnie = (int)stopnieWpis.Value;
            double radiany = (int)radianyWpis.Value;

            double radianyObl = (stopnie / 180.0f);
            double stopnieObl = (radiany * 180.0f);

            Radiany.Text = "Radiany: " + radianyObl + "pi";
            StopnieDane.Text = "Stopnie: " + stopnieObl / 3.14;

            // pobieranie informacji o funkcji liniowej

            double a1 = (double)numericUpDownA1.Value;
            double b1 = (double)numericUpDownB1.Value;
            double start1 = (double)numericUpDownStart1.Value;
            double n1 = (double)numericUpDownEnd1.Value;

            // pobieranie informacji o funkcji kwadratowej

            double a2 = (double)numericUpDownA2.Value;
            double b2 = (double)numericUpDownB2.Value;
            double c2 = (double)numericUpDownC2.Value;
            double start2 = (double)numericUpDownStart2.Value;
            double n2 = (double)numericUpDownEnd2.Value;

            ChartValues<ObservablePoint> valuesQuadratic = new ChartValues<ObservablePoint>();
            ChartValues<ObservablePoint> valuesLinear = new ChartValues<ObservablePoint>();

            for (double i = start1; i <= n1; i++)
            {
                valuesLinear.Add(new ObservablePoint(i, a1 * i + b1)); // Wykres y = ax + b
            }

            for (double i = start2; i <= n2; i++)
            {
                valuesQuadratic.Add(new ObservablePoint(i, a2 * Math.Pow(i, 2) + b2 * i + c2)); // Przykładowa funkcja y = ax^2 + bx + c
            }

            cartesianChart1.Series.Clear();

            // Każdy punkt pokazuje swój wzór (f. kwadratowa)
            cartesianChart1.Series.Add(new LineSeries
            {
                Values = valuesQuadratic,
                Title = "y = x²",
                PointGeometrySize = 15
            });
            // Każdy punkt pokazuje swój wzór (f. liniowa)
            cartesianChart1.Series.Add(new LineSeries
            {
                Values = valuesLinear,
                Title = "y = ax + b",
                PointGeometrySize = 15
            });

            // Obliczenia dla funkcji liniowej
            string monotonicity = DetermineMonotonicity(a1);
            string yIntercept = CalculateYIntercept(b1);
            double[] zeros = CalculateZeros(a1, b1);

            // Obliczenia dla funkcji kwadratowej
            double delta2 = CalculateDelta(a2, b2, c2);
            double symmetryAxis2 = CalculateSymmetryAxis(a2, b2);
            double[] zeros2 = CalculateZeros2(a2, b2, c2);
            string yIntercept2 = CalculateYIntercept(c2);
            string monotonicity2 = DetermineMonotonicity(a2);

            //LINIOWA
            labelZeros.Text = "Miejsca zerowe: " + (zeros.Length > 0 ? string.Join(", ", zeros) : "Brak miejsc zerowych");
            labelYIntercept.Text = "Przecięcie z osią Y: " + yIntercept.ToString();
            labelMonotonicity.Text = "Monotoniczność: " + monotonicity;

            //KWADRATOWA
            labelSymmetryAxis.Text = "Oś symetrii: " + symmetryAxis2.ToString();
            Delta.Text = "Delta: " + delta2.ToString();
            labelZeros2.Text = "Miejsca zerowe: " + (zeros2.Length > 0 ? string.Join(", ", zeros2) : "Brak miejsc zerowych");
            labelYIntercept2.Text = "Przecięcie z osią Y: " + yIntercept2.ToString();
            labelMonotonicity2.Text = "Monotoniczność: " + monotonicity2;

            //KÓŁKO
            double radi = (double)kolkoRadiany.Value;
            RadianyWKolko(radi);


        }

        // Funkcja obliczająca deltę dla funkcji kwadratowej
        private double CalculateDelta(double a, double b, double c)
        {
            return b * b - 4 * a * c;
        }

        // Funkcja obliczająca miejsca zerowe funkcji kwadratowej
        private double[] CalculateZeros2(double a, double b, double c)
        {
            double delta = CalculateDelta(a, b, c);
            if (delta < 0) return new double[] { }; // Brak miejsc zerowych
            else if (delta == 0) return new double[] { -b / (2 * a) }; // Jedno miejsce zerowe
            else
            {
                double root1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double root2 = (-b - Math.Sqrt(delta)) / (2 * a);
                return new double[] { root1, root2 }; // Dwa miejsca zerowe
            }
        }
        // Funkcja obliczająca miejsca zerowe funkji liniowej

        private double[] CalculateZeros(double a, double b)
        {
            return new double[] { -b /  a};
        }

        // Funkcja obliczająca oś symetrii funkcji kwadratowej
        private double CalculateSymmetryAxis(double a, double b)
        {
            return -b / (2 * a);
        }

        // Funkcja obliczająca przecięcie z osią Y
        private string CalculateYIntercept(double c)
        {
            return $"0;{c}";
        }

        // Funkcja określająca monotoniczność funkcji kwadratowej
        private string DetermineMonotonicity(double a)
        {
            if (a > 0) return "Rosnąca po osi X (minimum)";
            else if (a < 0) return "Malejąca po osi X (maksimum)";
            else return "Brak monotoniczności";
        }

        private void RadianyWKolko(double radiany)
        {
            double degrees = radiany * (180 / Math.PI);
            degrees = degrees % 360;
            int percentage = Convert.ToInt32((degrees / 360) * 100);

            circularProgressBar1.Value = percentage;
        }

        //inne komponenty programu które nie mają kodu, lecz pełnią funkję dekoracyjną UI/UX
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void Delta_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click_1(object sender, EventArgs e)
        {

        }

        private void label15_Click_1(object sender, EventArgs e)
        {

        }
    }
}