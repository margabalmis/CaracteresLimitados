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

namespace CaracteresLimitados
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int contadorCaracteresEscritos = 0;
       
        public MainWindow()
        {
            InitializeComponent();
            numeroCaracteresTextBox.Text = contadorCaracteresEscritos.ToString();

        }
        private void escrituraTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            contadorCaracteresEscritos = escrituraTextBox.Text.Length;
        }

        
    }
}
