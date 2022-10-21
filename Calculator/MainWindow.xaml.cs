using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Calculator
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button && label_number.Content.ToString()?.Length < 16)
                switch (button.Content)
                {
                    case "0":
                        if (!(label_number.Content.ToString() == "0"))
                            label_number.Content += "0";
                        break;
                    case "1":
                        if (label_number.Content.ToString() == "0")
                            label_number.Content = "1";
                        else label_number.Content += "1";
                        break;
                    case "2":
                        if (label_number.Content.ToString() == "0")
                            label_number.Content = "2";
                        else label_number.Content += "2";
                        break;
                    case "3":
                        if (label_number.Content.ToString() == "0")
                            label_number.Content = "3";
                        else label_number.Content += "3";
                        break;
                    case "4":
                        if (label_number.Content.ToString() == "0")
                            label_number.Content = "4";
                        else label_number.Content += "4";
                        break;
                    case "5":
                        if (label_number.Content.ToString() == "0")
                            label_number.Content = "5";
                        else label_number.Content += "5";
                        break;
                    case "6":
                        if (label_number.Content.ToString() == "0")
                            label_number.Content = "6";
                        else label_number.Content += "6";
                        break;
                    case "7":
                        if (label_number.Content.ToString() == "0")
                            label_number.Content = "7";
                        else label_number.Content += "7";
                        break;
                    case "8":
                        if (label_number.Content.ToString() == "0")
                            label_number.Content = "8";
                        else label_number.Content += "8";
                        break;
                    case "9":
                        if (label_number.Content.ToString() == "0")
                            label_number.Content = "9";
                        else label_number.Content += "9";
                        break;
                    case "%":
                        break;
                    case "CE":
                        break;
                    case "C":
                        break;
                    case "1/x":
                        break;
                    case "x²":
                        break;
                    case "²√x":
                        break;
                    case "/":
                        AddOperator("/");
                        break;
                    case "x":
                        AddOperator("x");
                        break;
                    case "-":
                        AddOperator("-");
                        break;
                    case "+":
                        AddOperator("+");
                        break;
                    case "+/-":
                        break;
                    case ",":
                        break;
                    case "=":
                        EqualOperation();
                        break;
                    default:
                        if ((string)button.Tag == "del")
                            break;
                        break;
                }
        }
        bool HasOperation()
        {
            if (((string)label_cache.Content).Last() == '+' || ((string)label_cache.Content).Last() == '-' || ((string)label_cache.Content).Last() == 'x' || ((string)label_cache.Content).Last() == '/')
                return true;
            return false;
        }

        bool HasEqual()
        {
            if (((string)label_cache.Content).Last() == '=')
                return true;
            return false;
        }

        void EqualOperation()
        {
            string firstOp = "";
            if (!HasEqual())
            {
                int i;
                for (i = 0; i < ((string)label_cache.Content).Length; i++)
                {
                    if (int.TryParse(((string)label_cache.Content)[i].ToString(), out _))
                        firstOp += ((string)label_cache.Content)[i];
                    else break;
                }
                switch (((string)label_cache.Content)[i])
                {
                    case '+':
                        label_cache.Content += (string)label_number.Content;
                        label_number.Content = (int.Parse(firstOp) + int.Parse((string)label_number.Content)).ToString();
                        break;
                    case '-':
                        label_cache.Content += (string)label_number.Content;
                        label_number.Content = (int.Parse(firstOp) - int.Parse((string)label_number.Content)).ToString();
                        break;
                    case 'x':
                        label_cache.Content += (string)label_number.Content;
                        label_number.Content = (int.Parse(firstOp) * int.Parse((string)label_number.Content)).ToString();
                        break;
                    case '/':
                        label_cache.Content += (string)label_number.Content;
                        label_number.Content = (int.Parse(firstOp) / int.Parse((string)label_number.Content)).ToString();
                        break;
                }
                label_cache.Content += "=";
            }
            else
            {
              
            }
        }

        void AddOperator(string op)
        {
            if (HasEqual())
            {
                label_cache.Content = (string)label_number.Content;
            }
            if (!(label_cache.Content.ToString() == "0"))
            {
                if (!HasOperation())
                {
                    label_cache.Content += op;
                    label_number.Content = "0";
                }
                else
                {
                    label_cache.Content = ((string)label_cache.Content).Remove(((string)label_cache.Content).Length - 1, 1);
                    label_cache.Content += op;
                    label_number.Content = "0";
                }
            }
            else if (!(label_number.Content.ToString() == "0"))
            {
                label_cache.Content = (string)label_number.Content;
                label_number.Content = "0";
                AddOperator(op);
            }

        }
    }
}
