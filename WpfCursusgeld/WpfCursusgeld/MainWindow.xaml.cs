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

namespace WpfCursusgeld
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

        private void berekenKnop_Click(object sender, RoutedEventArgs e)
        {

            int inputJaar;
            bool isNumeriek = int.TryParse(yearTextBox.Text, out inputJaar);
            double price = 1.5;
            double jaaringave = double.Parse(yearTextBox.Text);
            double inPutLesuren = double.Parse(hoursTextBox.Text);
            double totaalInschrijvingsgeld;
            
            totaalInschrijvingsgeld = inPutLesuren * price;
            double totaalInschrijvingsgeldSchrikkeljaar = inPutLesuren * price + 1.5;
            

            if (jaaringave % 400 == 0 && jaaringave % 4 ==0)  //is jaaringave deelbaar door 400 of 4 (dan bekom je 0)
            {
                isSchrikkeljaarTextBox.Text = "Dit is een schrikkeljaar";
                totaalTextBox.Text = ($"{totaalInschrijvingsgeldSchrikkeljaar}");

            }else
            {
                totaalTextBox.Text = ($"{totaalInschrijvingsgeld}");
                isSchrikkeljaarTextBox.Text = "Dit is geen schrikkeljaar";
            }




        }

        private void numeriekButton_Click(object sender, RoutedEventArgs e)
        {
            int inputJaar;
            bool isNumeriek = int.TryParse(yearTextBox.Text, out inputJaar);
            if (isNumeriek == true)
            {
                isNumeriekTextBox.Text = "Is numeriek";

            }
            else
            {
                isNumeriekTextBox.Text = "Geef een correct jaartal!";
            }
            
            
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void isNumeriekTextBox_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            
        }

        private void yearTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            isNumeriekTextBox.Clear();
        }
    }
    }



