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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(sender is Button button && label_number.Content.ToString()?.Length<16)
                switch (button.Content)
                {
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
                    default:
                        break;
                }
        }
    }
}
