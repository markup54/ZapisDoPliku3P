using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace ZapisDoPliku3P
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Uczen> uczniowie { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            przygotujDane();
            //listaUczniow.ItemsSource = uczniowie;
            DataContext= this;
        }

        public void przygotujDane()
        {
            uczniowie = new ObservableCollection<Uczen>();
            uczniowie.Add(new Uczen("Zosia", "Samosia", false, "3P"));
            uczniowie.Add(new Uczen("Edek", "Fedek", true, "3P"));
        }
    }
}
