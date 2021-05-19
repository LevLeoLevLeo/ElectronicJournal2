using ElectronicJournal2.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ElectronicJournal2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_CloseApp_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Btn_LogIn_Click(object sender, RoutedEventArgs e)
        {
            if (Txb_Email.Text == "1")
            {
                WindowsFrames.teacherWindow.Show();
                Close();
            }
        }

        private void Chb_ShowPassword_Click(object sender, RoutedEventArgs e)
        {

            if (Chb_ShowPassword.IsChecked == true)
            {
                TxB_ShowPassword.Text = Pssb_Password.Password;
                Pssb_Password.Clear();
                Pssb_Password.Visibility = Visibility.Collapsed;
                TxB_ShowPassword.Visibility = Visibility.Visible;
            }
            else
            {
                Pssb_Password.Password = TxB_ShowPassword.Text;
                TxB_ShowPassword.Clear();
                TxB_ShowPassword.Visibility = Visibility.Collapsed;
                Pssb_Password.Visibility = Visibility.Visible;
            }

        }
    }
}
