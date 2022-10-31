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
using System.Windows.Shapes;

namespace Var9
{
    /// <summary>
    /// Interaction logic for ex2window.xaml
    /// </summary>
    public partial class ex2window : Window
    {
        public ex2window()
        {
            InitializeComponent();
        }

        private void AccBtn_Click(object sender, RoutedEventArgs e)
        {
            int res = 0;
            char[] Alph = { 'а', 'у', 'о', 'ы', 'э', 'я', 'ю', 'ё', 'и', 'е' };
            char[] Line = mainTb.Text.ToLower().Replace(" ", "").ToCharArray();
            foreach (char ch in Line)
                foreach (char al in Alph)
                    if (ch == al)
                    {
                        res++;
                        break;
                    }

            outputLbl.Content = res.ToString();
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            this.Hide();
            main.ShowDialog();
            this.Close();
        }
    }
}
