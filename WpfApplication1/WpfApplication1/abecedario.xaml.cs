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
    /// Interaction logic for abecedario.xaml
    /// </summary>
    public partial class abecedario : MetroWindow
    {
        vocales v;

        public abecedario()
        {
        v = new vocales();
           
            InitializeComponent();
        }

        private void Image_MouseEnter(object sender, MouseEventArgs e)
        {
            v.voca_MouseEnter(sender,e);
        }

        private void Image_MouseLeave(object sender, MouseEventArgs e)
        {
            v.voca_MouseLeave(sender, e);
        }
    }
}
