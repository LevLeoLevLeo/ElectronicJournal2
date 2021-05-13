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
            this.Close();
        }

        private void Btn_LogIn_Click(object sender, RoutedEventArgs e)
        {
            if (Txb_Email.Text == "1")
            {
                Teacher.TeacherWindow teacherWindow = new Teacher.TeacherWindow();
                teacherWindow.Show();
                this.Close();
            }
        }
    }
}
