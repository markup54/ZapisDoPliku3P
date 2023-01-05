using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace ZapisDoPliku3P
{
    /// <summary>
    /// Logika interakcji dla klasy Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Click_Zamknij(object sender, RoutedEventArgs e)
        {
            MessageBoxResult okno =  MessageBox.Show("Czy na pewno chcesz zamknąć to okno?",
                "Zamykanie",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question);
            if(okno== MessageBoxResult.Yes) {
                this.Close();
            }
        }

        private void Click_Nowe_Modalne(object sender, RoutedEventArgs e)
        {
            var okno = new WindowNowe();
            okno.ShowDialog();
        }

        private void Click_Nowe_niemodalne(object sender, RoutedEventArgs e)
        {
            var okno = new WindowNowe();
            okno.Show();
        }

        private void Zapisz_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog oknoZapisu = new SaveFileDialog();
            oknoZapisu.Filter = "PlainText | *.txt";
            oknoZapisu.Title = "Zapisywanie";
            if(oknoZapisu.ShowDialog() == true)
            {
                File.WriteAllText(oknoZapisu.FileName, tekstDoZapisu.Text);
            }
        }

        private void Otworz_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog otwieranyPlik = new OpenFileDialog();
            otwieranyPlik.Filter = "PlainText | *.txt";
            otwieranyPlik.Title = "Otwieranie pliku";
            if(otwieranyPlik.ShowDialog() == true)
            {
                tekstDoZapisu.Text = File.ReadAllText(otwieranyPlik.FileName);
            }
        }
    }
}
