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

namespace WpfApplication4
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
        private void funcxxx(object sender, RoutedEventArgs e) { 
            if(e.OriginalSource == imas){
                tbl.Text = "iDOLM@STER!!!!!";
            }
            else if(e.OriginalSource == kon){
                tbl.Text = "K-ON!!!!!!!";
            }
            else if (e.OriginalSource == oreshura) {
                tbl.Text = "OreShura!!!!!";
            }
            else if (e.OriginalSource == haganai) {
                tbl.Text = "Haganai!!!!";
            }
        }
    }
}
