using System;
using System.Collections.Generic;
using System.Linq;
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
//using System.EventArgs;
using System.Windows.Forms;
using Microsoft.Win32;

namespace WpfApplication2
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

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
        private void richtextbox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            richtextbox1.Text = "";
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog cuadro_dialogo;
            cuadro_dialogo = new Microsoft.Win32.OpenFileDialog();
            cuadro_dialogo.ShowDialog();
            if (System.Windows.Forms.DialogResult.OK == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader Leer = new System.IO.StreamReader(cuadro_dialogo.FileName);
                richtextbox1.Text = Leer.ReadToEnd();
            };
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog cuadro_dialogo;
            cuadro_dialogo = new Microsoft.Win32.SaveFileDialog();
            cuadro_dialogo.DefaultExt = ".text";
            cuadro_dialogo.InitialDirectory =@"C:\Users\family\Desktop";
            cuadro_dialogo.ShowDialog();
            //if (cuadro_dialogo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            if (System.Windows.Forms.DialogResult.OK == System.Windows.Forms.DialogResult.OK)
            {
                string ruta = cuadro_dialogo.FileName;
                System.IO.StreamWriter fichero = new System.IO.StreamWriter(ruta);
                fichero.Write(richtextbox1);
                fichero.Close();

            };
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}

