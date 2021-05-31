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
using System.Windows.Shapes;

namespace ElectronicJournal2.Teacher
{
    /// <summary>
    /// Логика взаимодействия для TeacherWindow.xaml
    /// </summary>
    public partial class TeacherWindow : Window
    {
        public TeacherWindow()
        {
           
            InitializeComponent();
            WindowsFrames.FrmNavPanel = Frm_NavPanel;                   
            WindowsFrames.FrmNavPanel.Navigate(new TeacherMainPage());          //Запись Frame в класс, автоматический переход на главную страницу, запись кнопки "Назад" в класс. 
            WindowsFrames.BtnGoBack = Btn_Back;
            
        }
       
        private void Btn_Back_Click(object sender, RoutedEventArgs e) //Кнопка "Назад".
        {
            WindowsFrames.FrmNavPanel.GoBack();
            if (!WindowsFrames.FrmNavPanel.CanGoBack)
            {
                Btn_Back.Visibility = Visibility.Hidden;
            }
        }
    }
}
