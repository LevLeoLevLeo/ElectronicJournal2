using ElectronicJournal2.Class;
using ElectronicJournal2.DataBase;
using ElectronicJournal2.Teacher;
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
            ClassDataBase.DBProjectJournal = new ProjectJournalEntities();
        }

        private void Btn_CloseApp_Click(object sender, RoutedEventArgs e) //Завершение приложения.
        {
            Application.Current.Shutdown();
        }

        private void Btn_LogIn_Click(object sender, RoutedEventArgs e) //Кнопка "Войти".
        {
            try //На случай ошибки.

            {
                var DBLogin = ClassDataBase.DBProjectJournal.User.FirstOrDefault
                    (Alien => Alien.Email == Txb_Email.Text && Alien.Password == Pssb_Password.Password || Alien.Email == Txb_Email.Text && Alien.Password == TxB_ShowPassword.Text); //Сравнение введеных данных с имеющейся БД.

                if (DBLogin == null) //Если введенные данные не совпали с записями в БД.

                {
                    Pssb_Password.Clear();
                    TxB_ShowPassword.Clear();
                    MessageBox.Show("Email или пароль введены неверно, попробуйте еще раз",
                        "Авторизация",
                        MessageBoxButton.OK, MessageBoxImage.Warning);

                }

                else

                {

                    switch (DBLogin.IdRole) //Переход на строницу корректной роли.

                    {

                        case 1:
                            TeacherWindow teacherWindow = new TeacherWindow();
                            teacherWindow.Show();
                            this.Close();
                            break;
                        case 2:
                            Administration.WindowAdmin windowAdmin = new Administration.WindowAdmin();
                            windowAdmin.Show();
                            this.Close();
                            break;
                        default:
                            MessageBox.Show("Что-то пошло не так, попробуйте снова.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                            break;

                    }

                }

            }

            catch (Exception error) //Если возникнет ошибка.

            {

                MessageBox.Show("Произошла ошибка " + error.Message.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);

            }
        }

        private void Chb_ShowPassword_Click(object sender, RoutedEventArgs e) //Функция "Показать пароль".
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
