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

namespace BasicCalculator
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

        private void sumBtn_Click(object sender, RoutedEventArgs e)
        {
            int n1 = int.Parse(num1Txt.Text);
            int n2 = int.Parse(num2Txt.Text);

            int result = n1 + n2;
            this.ResultTxt.Text = result.ToString();
        }

        private void subBtn_Click(object sender, RoutedEventArgs e)
        {
            int n1 = int.Parse(num1Txt.Text);
            int n2 = int.Parse(num2Txt.Text);

            int result = n1 - n2;
            this.ResultTxt.Text = result.ToString();
        }

        private void mulBtn_Click(object sender, RoutedEventArgs e)
        {
            int n1 = int.Parse(num1Txt.Text);
            int n2 = int.Parse(num2Txt.Text);

            int result = n1 * n2;
            this.ResultTxt.Text = result.ToString();
        }

        private void divBtn_Click(object sender, RoutedEventArgs e)
        {
            int n1 = int.Parse(num1Txt.Text);
            int n2 = int.Parse(num2Txt.Text);
            if (n2 == 0)
            {
                MessageBox.Show("!אין לחלק ב- 0");
            }
            else
            {
                int result = n1 / n2;
                this.ResultTxt.Text = result.ToString();
            }
        }


    }
}