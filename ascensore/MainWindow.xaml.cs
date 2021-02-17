using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;
using System.Diagnostics;


namespace ascensore
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private double inizio;
        private double fine;
        private double altezza;
        public MainWindow()
        {
            InitializeComponent();
            inizio = 10;
            fine = 750;
            altezza = 12;


            BitmapImage bitmap1 = new BitmapImage();
            bitmap1.BeginInit();
            bitmap1.UriSource = new Uri("uomo.png", UriKind.RelativeOrAbsolute);
            bitmap1.EndInit();
            personaggio.Source = bitmap1;
            personaggio.Margin = new Thickness(inizio, altezza, 0, -20);


            BitmapImage bitmap2 = new BitmapImage();
            bitmap2.BeginInit();
            bitmap2.UriSource = new Uri("uomo2.png", UriKind.RelativeOrAbsolute);
            bitmap2.EndInit();
            personaggio2.Source = bitmap2;
            personaggio2.Margin = new Thickness(inizio, altezza + 120, 0, 0);

            BitmapImage bitmap3 = new BitmapImage();
            bitmap3.BeginInit();
            bitmap3.UriSource = new Uri("elevator.png", UriKind.RelativeOrAbsolute);
            bitmap3.EndInit();
            elevatore.Source = bitmap3;
            elevatore.Margin = new Thickness(inizio, altezza + 267, 457, 50);

        }
    }
}
