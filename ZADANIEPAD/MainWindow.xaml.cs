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

            users.Add(new Szkola() { Miejsce = "Polska", Miasto = "Gdynia", Ulica = "Sambora", Nazwa = "ZSCHiE", Patron = "-" });
            users.Add(new Szkola() { Miejsce = "Hiszpania", Miasto = "Madryt", Ulica = "Plasencia", Nazwa = "MadritSchool", Patron = "Iker Casillas" });
            users.Add(new Szkola() { Miejsce = "Niemcy", Miasto = "Berlin", Ulica = "Marxheim", Nazwa = "Marxheim", Patron = "-" });
            users.Add(new Szkola() { Miejsce = "Francja", Miasto = "Lens", Ulica = "Lens", Nazwa = "Lens", Patron = "Lens" });
            users.Add(new Szkola() { Miejsce = "Portugalia", Miasto = "Lizbona", Ulica = "Lisbon", Nazwa = "LisSQL", Patron = "Ronaldo" });
            users.Add(new Szkola() { Miejsce = "Austria", Miasto = "Wieden", Ulica = "Aust", Nazwa = "As", Patron = "PA" });

            tabelka.ItemsSource = users;

            tabelka1.IsReadOnly = true;
            List<Szkola> users1 = new List<Szkola>();

            users1.Add(new Szkola() { Uczen = "Polska", Pracownik = "Gdynia", Nauczyciel = "Sambora"});
        

            tabelka1.ItemsSource = users;
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

            public string Uczen{ get; set; }

            public string Pracownik { get; set; }
            public string Nauczyciel { get; set; }
        }

        private void DODAWANIESZKOLA(object sender, RoutedEventArgs e)
        {
       
        }
    }
}
