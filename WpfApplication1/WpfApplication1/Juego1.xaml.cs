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
    /// Interaction logic for Juego1.xaml
    /// </summary>
    public partial class Juego1 : MetroWindow
    {UIElement source = null; int completo=0; string pver="";
        metodos[,] posicion = new metodos[2, 8];
        public string imagen = "",descomp="";
        int c = 0;
        public Juego1()
        {
            InitializeComponent();
            reseteo();
            asignar();
            botones();              
        }
       
        public void reseteo()
        {
            posicion[1, 0] = new metodos(false, 402, 45,"");
            posicion[1, 1] = new metodos(false, 402, 146,"");
            posicion[1, 2] = new metodos(false, 402, 232,"");
            posicion[1, 3] = new metodos(false, 402, 326,"");
            posicion[1, 4] = new metodos(false, 402, 422,"");
            posicion[1, 5] = new metodos(false, 402, 510,"");
            posicion[1, 6] = new metodos(false, 402, 607,"");
            posicion[1, 7] = new metodos(false, 402, 695,"");
            posicion[0, 0] = new metodos(true, 310, 45,"");
            posicion[0, 1] = new metodos(true, 310, 146,"");
            posicion[0, 2] = new metodos(true, 310, 232,"");
            posicion[0, 3] = new metodos(true, 310, 326,"");
            posicion[0, 4] = new metodos(true, 310, 422,"");
            posicion[0, 5] = new metodos(true, 310, 510,"");
            posicion[0, 6] = new metodos(true, 310, 607,"");
            posicion[0, 7] = new metodos(true, 310, 695,"");
        }



        public void encuentra(double x, double y)
        {
            string temp = "";
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 8; j++)
                {

                    if (x == posicion[i, j].altura && y == posicion[i, j].anchura)
                    {
                        temp = posicion[i, j].nombre;
                        posicion[i, j] = new metodos(!posicion[i, j].disponible, posicion[i, j].altura, posicion[i, j].anchura, "");
                   
                    }
                }
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (posicion[i, j].disponible == true && posicion[i, j].altura != x)
                    {
                       
                 
                        posicion[i, j] = new metodos(!posicion[i, j].disponible, posicion[i, j].altura, posicion[i, j].anchura, temp);
             
                        Canvas.SetTop(source, posicion[i, j].altura);
                        Canvas.SetLeft(source, posicion[i, j].anchura);
                     
                            
                        break;
                    }
                }

            }
          
verificapalabra();
        }
 
        public void verificapalabra()
        {

            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j <c; j++)
                {
                    if (posicion[i, j].nombre != "")
                    {
                        pver = pver + posicion[i, j].nombre;
                        //MessageBox.Show(pver);
                       
                    }
                       
                }
                if (pver.Length == imagen.Length )
                {
                    if (pver == imagen)
                        MessageBox.Show("CORRECTO!!!!!!");
                    else
                        MessageBox.Show("INCORRECTO!!!!");
                }
                pver = ""; 
            }

        }
    

     
        

     

        public void asignar()
        {
            Random r = new Random();
            int x = 1;
            x=r.Next(1,10);


            try
            {
                if (x % 2 == 0)
                {
                    imgprin.Source = new BitmapImage
                        (new Uri(@"C:\Users\RSMAPP\Source\Repos\M-Mkids\WpfApplication1\WpfApplication1\imagenes\gato.png"));
                    imagen = "gato";
                }
                else {    imgprin.Source = new BitmapImage
                 (new Uri(@"C:\Users\RSMAPP\Source\Repos\M-Mkids\WpfApplication1\WpfApplication1\imagenes\perro.jpg"));
                imagen = "perro";
                }

                descomp = imagen;
            }
            catch (Exception e) { }
         
            }

        public void botones()
        {
             c = 0;
            if (c<imagen.Length)
            {
                bt1.Content = letra();
                hasvisible(bt1);
                hasvisible(lb1);
                posicion[1, c] = new metodos(posicion[1, c].disponible, posicion[1, c].altura, posicion[1, c].anchura, bt1.Content.ToString());
                     
                c++;
            }
            if (c < imagen.Length)
            {
                bt2.Content = letra();
                hasvisible(bt2);
                hasvisible(lb2);
                posicion[1, c] = new metodos(posicion[1, c].disponible, posicion[1, c].altura, posicion[1, c].anchura, bt2.Content.ToString());
                c++;
            }
            if (c < imagen.Length)
            {
                bt3.Content = letra();
                 hasvisible(bt3);
                 hasvisible(lb3);
                 posicion[1, c] = new metodos(posicion[1, c].disponible, posicion[1, c].altura, posicion[1, c].anchura, bt3.Content.ToString());
                c++;
            }
            if (c < imagen.Length)
            {
                bt4.Content = letra();
                hasvisible(bt4);
                hasvisible(lb4);
                posicion[1, c] = new metodos(posicion[1, c].disponible, posicion[1, c].altura, posicion[1, c].anchura, bt4.Content.ToString());
                c++;
            }
            if (c < imagen.Length)
            {
                bt5.Content = letra(); 
                hasvisible(bt5);
                hasvisible(lb5);
                posicion[1, c] = new metodos(posicion[1, c].disponible, posicion[1, c].altura, posicion[1, c].anchura, bt5.Content.ToString());
                c++;
               
            }
            if (c < imagen.Length)
            {
                bt6.Content = letra();
                hasvisible(bt6);
                hasvisible(lb6);
                posicion[1, c] = new metodos(posicion[1, c].disponible, posicion[1, c].altura, posicion[1, c].anchura, bt6.Content.ToString());
                c++;
            }
            if (c < imagen.Length)
            {
                bt7.Content = letra();
                hasvisible(bt7);
                hasvisible(lb7);
                posicion[1, c] = new metodos(posicion[1, c].disponible, posicion[1, c].altura, posicion[1, c].anchura, bt7.Content.ToString());
                c++;
            }
            if (c < imagen.Length)
            {
                bt8.Content = letra();

                hasvisible(bt8);
                hasvisible(lb8);
                posicion[1, c] = new metodos(posicion[1, c].disponible, posicion[1, c].altura, posicion[1, c].anchura,bt8.Content.ToString());
                c++;
            }
        }
        public void hasvisible(UIElement sur)
        {
            sur.Visibility=System.Windows.Visibility.Visible;

        }
        public char letra()
        {
            int t = 0;
            int max = imagen.Length;
            char valor = ' ';
            while (valor == ' ')
            {
                Random d = new Random();
    
                t = d.Next(0,max);
                if (descomp[t] != ' ')
                {
                    valor = descomp[t];
                    char[] arr;
                    arr = descomp.ToCharArray();
                    arr[t] = ' ';
                    descomp = new string(arr);
                    break;
                }
            }

            return valor;
        }

        private void bt1_Click(object sender, RoutedEventArgs e)
        {
            source = (UIElement)sender;
            double x, y;
            x = Canvas.GetLeft(source);
            y = Canvas.GetTop(source);
            encuentra(y, x);
        }





    }
}
