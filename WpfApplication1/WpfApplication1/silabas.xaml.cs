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
using System.Windows.Shapes;
using MahApps.Metro.Controls;


namespace MMKids
{
    /// <summary>
    /// Interaction logic for silabas.xaml
    /// </summary>
    public partial class silabas : MetroWindow
    {
        public silabas()
        {
            InitializeComponent();
        }

        private void B_Click(object sender, RoutedEventArgs e)
        {   Button nb=(Button)sender;
            string contenido="X";
            contenido = nb.Name.ToString();
            b1.Content = contenido + "a";
            b2.Content = contenido + "e";
            b3.Content = contenido + "i";
            b4.Content = contenido + "o";
            b5.Content = contenido + "u";
        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            imp.Source = new BitmapImage(new Uri(@"C:\Users\RSMAPP\Source\Workspaces\Tesis MM final\WpfApplication1\WpfApplication1\imagenes\barco.jpg"));
        }

     
    }
}
