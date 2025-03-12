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
        public  void oblicz1()
        {
          




        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Int128 a = 0;
            int ile;

            Int32.TryParse(ilosc.Text,out ile);
            
            Int128[] tablica = new Int128[ile];

            tablica[0] = 0;
            tablica[1] = 1;

            for (int i = 2; i < ile; i++)
            {
                tablica[i] = tablica[i - 2] * tablica[i - 1];
                Console.WriteLine(tablica[i]);

            }


        }
    }
}