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
    /// Interaction logic for vocales.xaml
    /// </summary>
    public partial class vocales : MetroWindow
    {
        public vocales()
        {
            InitializeComponent();
        }

     public void voca_MouseEnter(object sender, MouseEventArgs e)
        {
            Image im = (Image)sender;
            im.Height = im.ActualHeight+im.ActualHeight * 0.10;
            im.Width = im.ActualWidth+im.ActualWidth*0.10;
            
        }

       public void voca_MouseLeave(object sender, MouseEventArgs e)
        {
            Image im = (Image)sender;
            im.Height = im.ActualHeight - im.ActualHeight * 0.10;
            im.Width = im.ActualWidth - im.ActualWidth * 0.10;

        }
    }
}
