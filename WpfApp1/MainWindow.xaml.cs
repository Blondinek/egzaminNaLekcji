using System;
using System.Reflection.Metadata;
using System.Windows;
using System.Windows.Controls;

namespace ObslugaPocztyWPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
     

        private void SprawdzCeneButton_Click(object sender, RoutedEventArgs e)
        {
            string wybranaOpcja = "";

            if (PocztowkaRadioButton.IsChecked == true)
            {
                wybranaOpcja = "Pocztówka";
                CenaLabel.Content = "Cena: 1 zł";
                CenaLabel.Visibility = Visibility.Visible;
            }
            else if (ListRadioButton.IsChecked == true)
            {
                wybranaOpcja = "List";
                CenaLabel.Content = "Cena: 1,5 zł";
                CenaLabel.Visibility = Visibility.Visible;
            }
            else if (PaczkaRadioButton.IsChecked == true)
            {
                wybranaOpcja = "Paczka";
                CenaLabel.Content = "Cena: 10 zł";
                CenaLabel.Visibility = Visibility.Visible;
            }

            MessageBox.Show($"Wybrano opcję: {wybranaOpcja}");
        }

        private void ZatwierdzButton_Click(object sender, RoutedEventArgs e)
        {
            string kodPocztowy = KodPocztowyTextBox.Text;

            if (kodPocztowy.Length != 5)
            {
                MessageBox.Show("Nieprawidłowa liczba cyfr w kodzie pocztowym");
            }
            else if (!IsNumeric(kodPocztowy))
            {
                MessageBox.Show("Kod pocztowy powinien się składać z samych cyfr");
            }
            else
            {
                MessageBox.Show("Dane przesyłki zostały wprowadzone");
            }
        }

        private bool IsNumeric(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}