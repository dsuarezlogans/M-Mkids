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
    /// Interaction logic for Juegos.xaml
    /// </summary>
    public partial class Juegos : MetroWindow
    {
        public Juegos()
        {
            InitializeComponent();
        }

        private void Grid_MouseEnter(object sender, MouseEventArgs e)
        {

        }

     
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Juego1 j1 = new Juego1();
            j1.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            esconder();
            Button jc = (Button)sender;
            if(jc.Name.ToString()=="bj2")
                juego2.Visibility = System.Windows.Visibility.Visible;
            else if(jc.Name.ToString()=="bj3")
            juego3.Visibility = System.Windows.Visibility.Visible;


        }

        public void esconder()
        {
            juego2.Visibility = System.Windows.Visibility.Collapsed;
            juego3.Visibility = System.Windows.Visibility.Collapsed;
        }
    }
}
