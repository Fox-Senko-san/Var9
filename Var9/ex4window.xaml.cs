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
    /// Interaction logic for ex4window.xaml
    /// </summary>
    public partial class ex4window : Window
    {
        public ex4window()
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

                if (mas.Length >= 5)
                {
                    string temp = mas[2];
                    mas[2] = mas[4];
                    mas[4] = temp;

                    foreach (string word in mas)
                        outputLbl.Content += word + " ";
                }
                else
                    outputLbl.Content = "Введен массив меньше 5 элементов";
            }
            catch
            {
                outputLbl.Content = "Ошибка ввода";
            }
        }
    }
}
