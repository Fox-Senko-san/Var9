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
    /// Interaction logic for ex3window.xaml
    /// </summary>
    public partial class ex3window : Window
    {
        public ex3window()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            this.Hide();
            main.ShowDialog();
            this.Close();
        }

        private void AccBtn_Click(object sender, RoutedEventArgs e)
        {
            outputLbl.Content = "";
            try
            {
                char[] sep = { ' ', ',', ';' };
                string[] mas = mainTb.Text.Split(sep, StringSplitOptions.RemoveEmptyEntries);

                if (mas.Length > 2)
                {
                    for (int i = 1; i < mas.Length - 1; i++)
                    {
                        if (Convert.ToInt32(mas[i]) % 2 != 0)
                            continue;
                        mas[i] = Convert.ToString(Convert.ToInt32(mas[i]) + Convert.ToInt32(mas[mas.Length - 1]));
                    }
                    foreach (string word in mas)
                    {
                        outputLbl.Content += word + " ";
                    }
                }
                else
                    outputLbl.Content = "Введен слишком короткий массив";
            }
            catch
            {
                outputLbl.Content = "Введен не масив чисел";
            }
        }
    }
}
