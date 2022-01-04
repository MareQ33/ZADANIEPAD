using Microsoft.Win32;
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

namespace ZADANIEPAD
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            tabelka.IsReadOnly = true;
            List<Szkola> users = new List<Szkola>();
        }

        private void BtnClick1(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                Uri fileUri = new Uri(openFileDialog.FileName);
            }
        }

        private void dodawanie_Click(object sender, RoutedEventArgs e)
        {
            bool dodawaniedotab = tabelka.IsReadOnly;
            tabelka.IsReadOnly = !dodawaniedotab;
        }

        public class Szkola
        {
            public string Miejsce { get; set; }

            public string Miasto { get; set; }

            public string Ulica { get; set; }

            public string Nazwa { get; set; }

            public string Patron { get; set; }
        }
    }
}
