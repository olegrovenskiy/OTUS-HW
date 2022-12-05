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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int num1 = 0;
        int num2 = 0;
        string op = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_num_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            String str = button.Content.ToString();
            int num = Int32.Parse(str);

            
            if (op == "")
            {
                num1 = 10 * num1 + num;
                txtValue.Text = num1.ToString();
            }
            else
            {
                num2 = 10 * num2 + num;
                txtValue.Text = num2.ToString();
            }

        }

        private void btn_plus_Click(object sender, RoutedEventArgs e)
        {
            op = "+";
        }

        private void btn_eq_Click(object sender, RoutedEventArgs e)
        {
            int result = 0;
            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;
            }
            txtValue.Text = result.ToString();
            op = "";
            num1 = result;
        }

        private void btn_minus_Click(object sender, RoutedEventArgs e)
        {
            op = "-";
        }

        private void btn_mult_Click(object sender, RoutedEventArgs e)
        {
            op = "*";
        }

        private void btn_dif_Click(object sender, RoutedEventArgs e)
        {
            op = "/";
        }



    }
}
