using ElectronicJournal2.Class;
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

namespace ElectronicJournal2.Teacher
{
    /// <summary>
    /// Логика взаимодействия для TeacherMainPage.xaml
    /// </summary>
    public partial class TeacherMainPage : Page
    {
        public TeacherMainPage()
        {
            InitializeComponent();

        }

        private void Btn_CloseApp_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Btn_LogOut_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Btn_ChoiceJournal_Click(object sender, RoutedEventArgs e)
        {
            WindowsFrames.FrmNavPanel.Navigate(new TeacherChoiceJournal());
            WindowsFrames.BtnGoBack.Visibility = Visibility.Visible;
        }
    }
}
