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


namespace Calculator_try1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string currentValue, textValue;
        Variable mainValue = new Variable();        
        public MainWindow()
        {
            InitializeComponent();            
            currentValue = "";
            textValue = "";
        }
        
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            //send the current entered value and the addition key (0)
            mainValue.Assign(currentValue, 0);
            //copy the current value to the text value to send it to screem
            updateTextWithOperator(" + ");
            
            
        }

        private void btnSub_Click(object sender, RoutedEventArgs e)
        {                      
            //send the current entered value and the subtraction key (1)
            mainValue.Assign(currentValue, 1);
            //copy the current value to the text value to send it to screem
            updateTextWithOperator(" - ");
            
        }

        private void btnMul_Click(object sender, RoutedEventArgs e)
        {                        
            //send the current entered value and the multiplication key (2)
            mainValue.Assign(currentValue, 2);
            //copy the current value to the text value to send it to screem
            updateTextWithOperator(" x ");
            


        }

        private void btnDiv_Click(object sender, RoutedEventArgs e)
        {                        
            //send the current entered value and the division key (3)
            mainValue.Assign(currentValue, 3);
            //copy the current value to the text value to send it to screem
            updateTextWithOperator(" / ");
            if(mainValue.illegalMsg != "")
            {
                updateText(mainValue.illegalMsg);
            }
            

        }

        private void btnPer_Click(object sender, RoutedEventArgs e)
        {
            //send the current entered value and the division key (3)
            mainValue.Assign(currentValue, 4);
            //copy the current value to the text value to send it to screem
            updateTextWithOperator(" % ");
            

        }

        private void btnSign_Click(object sender, RoutedEventArgs e)
        {
            currentValue = "-"+currentValue;
            //copy the current value to the text value to send it to screem
            updateText("(-)");
            

        }

        private void btnMod_Click(object sender, RoutedEventArgs e)
        {
            mainValue.Assign(currentValue, 6);
            //copy the current value to the text value to send it to screem
            updateTextWithOperator(" mod ");
            

        }

        private void btnEqu_Click(object sender, RoutedEventArgs e)
        {
            mainValue.Assign(currentValue, 7);
            if (mainValue.illegalMsg != "")
            {
                txtResult.Text = mainValue.illegalMsg;
            }
            else
            {
                txtResult.Text = "= " + mainValue.Value.ToString();
            }
            
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            currentValue += "7";
            updateText("7");
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            currentValue += "8";
            updateText("8");
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            currentValue += "9";
            updateText("9");
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            currentValue += "4";
            updateText("4");
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            currentValue += "5";
            updateText("5");
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            currentValue += "6";
            updateText("6");
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            currentValue += "1";
            updateText("1");
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            currentValue += "2";
            updateText("2");
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            currentValue += "3";
            updateText("3");
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            currentValue += "0";
            updateText("0");
        }

        private void btnDec_Click(object sender, RoutedEventArgs e)
        {
            currentValue += ".";
            updateText(".");
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            currentValue = "";
            mainValue.Reset();
            txtResult.Text = "";
        }

        private void updateText(string newTxt)
        {
            txtResult.Text += newTxt;            
        }
        private void updateTextWithOperator(string newTxt)
        {
            txtResult.Text += newTxt;
            currentValue = "";
        }
    }
}
