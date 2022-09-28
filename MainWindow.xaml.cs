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

namespace ej2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
            private void limpiarClickButton(object sender, RoutedEventArgs e)
            {
                op1TextBox.Text = "";
                op2TextBox.Text = "";
                operadorTextBox.Text = "";
                resultadoTextBox.Text = "";
                calcularButton.IsEnabled = false;
            }

            private void calcularClickButton(object sender, RoutedEventArgs e)
            {
                try
                {
                    int op1 = int.Parse(op1TextBox.Text);
                    int op2 = int.Parse(op2TextBox.Text);

                    switch (operadorTextBox.Text)
                    {
                        case "+":
                            resultadoTextBox.Text = (op1 + op2).ToString();
                            break;
                        case "-":
                            resultadoTextBox.Text = (op1 - op2).ToString();
                            break;
                        case "*":
                            resultadoTextBox.Text = (op1 * op2).ToString();
                            break;
                        case "/":
                            resultadoTextBox.Text = (op1 / op2).ToString();
                            break;
                    }
                }
                catch
                {
                    MessageBox.Show("Se ha producido un error. Revise los operandos.", "ERROR", MessageBoxButton.OK);
                }
                
            }

            private void operadorTextBox_TextChanged(object sender, TextChangedEventArgs e)
            {
                if (operadorTextBox.Text == "*" || operadorTextBox.Text == "+" || operadorTextBox.Text == "-" || operadorTextBox.Text == "/")
                    calcularButton.IsEnabled = true;
            } 
    
    }
}
