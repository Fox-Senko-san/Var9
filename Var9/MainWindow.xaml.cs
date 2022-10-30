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

namespace Var9
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

        private void Ex3btn_Click(object sender, RoutedEventArgs e)
        {
            ex3window ex3 = new ex3window();
            this.Hide();
            ex3.ShowDialog();
            this.Close();
        }

        private void Ex4btn_Click(object sender, RoutedEventArgs e)
        {
            ex4window ex4 = new ex4window();
            this.Hide();
            ex4.ShowDialog();
            this.Close();
        }
    }
}
