﻿using System;
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
    /// Interaction logic for numeros.xaml
    /// </summary>
    public partial class numeros : MetroWindow
    {
        vocales vc = new vocales();
        public numeros()
        {
            InitializeComponent();
        }

        private void in1_MouseEnter(object sender, MouseEventArgs e)
        {
            vc.voca_MouseEnter(sender, e);
        }

        private void in1_MouseLeave(object sender, MouseEventArgs e)
        {
            vc.voca_MouseLeave(sender, e);
        }
    }
}
