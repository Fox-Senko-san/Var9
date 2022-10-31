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
    /// Interaction logic for ex1window.xaml
    /// </summary>
    public partial class ex1window : Window
    {
        public ex1window()
        {
            InitializeComponent();
        }

        private void AccBtn_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                int Num = Convert.ToInt32(mainTb.Text);
                if (1 <= Num && Num <= 9999)
                {
                    outputLbl.Content = "";

                    if (Num % 2 == 0)
                        outputLbl.Content += "Четное ";
                    else
                        outputLbl.Content += "Нечетное ";

                    switch (mainTb.Text.Length)
                    {
                        case 1: outputLbl.Content += "одно"; break;
                        case 2: outputLbl.Content += "двух"; break;
                        case 3: outputLbl.Content += "трех"; break;
                        case 4: outputLbl.Content += "четырех"; break;
                    }

                    outputLbl.Content += "значное число";
                }
                else
                    MessageBox.Show("Задано число не из диапозона");
            }
            catch
            {
                MessageBox.Show("Введнено не число");
            }
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
