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

namespace WpfApplication3
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
        private void imas(object sender, RoutedEventArgs e) {
            MessageBox.Show("You want to watch iDOLM@STER!");
        }
        private void kon(object sender, RoutedEventArgs e) {
            MessageBox.Show("You want to watch K-ON!!!!");
        }
        private void absx(object sender, RoutedEventArgs e) {
            MessageBox.Show("You watch Angel Beats");
        }
        private void oreimo(object sender, RoutedEventArgs e) {
            MessageBox.Show("You want a tsundere imouto");
        }
        private void nakaimo(object sender, RoutedEventArgs e) {
            MessageBox.Show("You want a pettan imouto");
        }
        private void oniai(object sender, RoutedEventArgs e){
            MessageBox.Show("You want a overly-attached imouto!");
        }

    }
}
