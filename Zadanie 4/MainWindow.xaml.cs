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

namespace Zadanie_4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //teraz program działa tylko na podstawie tej wartości Grade ustawionej na początku
        //TODO z pola textbox uaktualnić pole Grade
        public int Grade { get; set; } = 80;
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }
    }
}
