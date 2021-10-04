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

namespace CuadrosTexto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            nombreTextBox.Tag = textBlockAyudaNombre;
            apellidoTextBox.Tag = textBlockAyudaApellido;
        }

        private void NombreYApellidoTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            TextBlock textBlock = (TextBlock)textBox.Tag;
            if (e.Key == Key.F1 && textBlock.Visibility != Visibility.Visible)
                textBlock.Visibility = Visibility.Visible;
            else if (e.Key == Key.F1 && textBlock.Visibility == Visibility.Visible)
                textBlock.Visibility = Visibility.Hidden;
        }

        private void Edad_KeyUp(object sender, KeyEventArgs e)
        {
            bool seHaPodidoParsear = Int32.TryParse(textBoxEdad.Text, out _);
            if (!seHaPodidoParsear)
                MessageBox.Show("¡No es un entero!");
        }
    }
}
