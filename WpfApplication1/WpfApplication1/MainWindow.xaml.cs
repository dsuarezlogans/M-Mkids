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
using MahApps.Metro.Controls;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace MMKids
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
           
 InitializeComponent();
               
              

        }

        private void btvoc_Click(object sender, RoutedEventArgs e)
        {
            vocales vc = new vocales();
            vc.vtvoc.Show();
        }

        private void btabc_Click(object sender, RoutedEventArgs e)
        {
            abecedario ab = new abecedario();
            ab.vtabec.Show();
        }

        private void btsil_Click(object sender, RoutedEventArgs e)
        {
            silabas sl = new silabas();
            sl.vtsilab.Show();
        }

        private void btlec_Click(object sender, RoutedEventArgs e)
        {
            Lecturas lc = new Lecturas();
            lc.vtlec.Show();

        }


        private void image5_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Juegos jg = new Juegos();
            jg.vtjugar.Show();
        }

        private void silabas_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	silabas sl = new silabas();
            sl.vtsilab.Show();
        }

        private void lectura_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Lecturas lc = new Lecturas();
            lc.vtlec.Show();
        }

        private void Rectangle_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            numeros num = new numeros();
            num.Show();
        }

      
        
    }
}
