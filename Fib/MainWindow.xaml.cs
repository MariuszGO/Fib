using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Fib
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
             public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           int ile; //wielkosc ciagu, ilosc elementow
            String tmp=" "; //zmienna pomocnicza do zapisu wyniku

            Int32.TryParse(ilosc.Text,out ile); //pobranie ilosci elementow z pola tekstowego
                                                //i zamiana pobranej wartości na int

            Int128[] tablica = new Int128[ile]; //utworzenie tablicy o wielkosci ile
                                                //typu Int128, aby pomiescic duze liczby
            tablica[0] = 0; //pierwszy element ciagu
            tablica[1] = 1; //drugi element ciagu

            for (int i = 2; i < ile; i++)
            {
                tablica[i] = tablica[i - 2] + tablica[i - 1];
              // Console.WriteLine(tablica[i]);
               tmp += tablica[i].ToString();
                tmp += " ";
            }

            wynik.Text = tmp;

        }
    }
}