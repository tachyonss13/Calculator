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

namespace CalculatorApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private bool NumCheck(out double num1, out double num2)
        {
            num1 = 0;
            num2 = 0;

            try
            {
                num1 = Convert.ToDouble(txtNumber1.Text);
                num2 = Convert.ToDouble(txtNumber2.Text);
                return true;
            }
            catch (FormatException)
            {
                ShowErrorMessage("Invalid number format.");
                return false;
            }
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            if (NumCheck(out double num1, out double num2))
            {
                double result = num1 + num2;
                lblResult.Content = $"Result: {result}";
                lblResult.Visibility = Visibility.Visible;
            }
        }

        private void Sub_Click(object sender, RoutedEventArgs e)
        {
            if (NumCheck(out double num1, out double num2))
            {
                double result = num1 - num2;
                lblResult.Content = $"Result: {result}";
                lblResult.Visibility = Visibility.Visible;
            }
        }

        private void Mul_Click(object sender, RoutedEventArgs e)
        {
            if (NumCheck(out double num1, out double num2))
            {
                double result = num1 * num2;
                lblResult.Content = $"Result: {result}";
                lblResult.Visibility = Visibility.Visible;
            }
        }

        private void Div_Click(object sender, RoutedEventArgs e)
        {
            if (NumCheck(out double num1, out double num2))
            {
                if (num2 == 0)
                {
                    ShowErrorMessage("Cannot divide by zero.");
                    return;
                }

                double result = num1 / num2;
                lblResult.Content = $"Result: {result}";
                lblResult.Visibility = Visibility.Visible;
            }
        }
    }
}