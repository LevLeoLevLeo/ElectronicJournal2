using ElectronicJournal2.Class;
using ElectronicJournal2.DataBase;
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

namespace ElectronicJournal2.Administration
{
    /// <summary>
    /// Логика взаимодействия для PageAddStudent.xaml
    /// </summary>
    public partial class PageAddStudent : Page
    {
        public PageAddStudent()
        {
            InitializeComponent();
            Cmd_Course.SelectedValuePath = "Id";
            Cmd_Course.DisplayMemberPath = "Course";
            Cmd_Course.ItemsSource = ClassDataBase.DBProjectJournal.Cousre.ToList();


            Cmd_Group.SelectedValuePath = "Id";
            Cmd_Group.DisplayMemberPath = "NameGroup";
            Cmd_Group.ItemsSource = ClassDataBase.DBProjectJournal.Group.ToList();

            Cmd_Spec.SelectedValuePath = "Id";
            Cmd_Spec.DisplayMemberPath = "NameSpecialization";
            Cmd_Spec.ItemsSource = ClassDataBase.DBProjectJournal.Specialization.ToList();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (Cmd_Group.SelectedItem == null || Cmd_Course.SelectedItem == null || Txb_Name.Text == null || Cmd_Spec.SelectedItem == null)

            {

                MessageBox.Show("Вы что-то не выбрали", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);

            }

            else
            {
                int x = Convert.ToInt32(Cmd_Course.SelectedValue);
                Student studentobj = new Student()

                {

                Name = Txb_Name.Text,
                IdGroup = x,
                IdSpecialization = (int)Cmd_Spec.SelectedValue,
                };

                ClassDataBase.DBProjectJournal.Student.Add(studentobj);
                ClassDataBase.DBProjectJournal.SaveChanges();
                MessageBox.Show("Студент добавлен!", "Студент", MessageBoxButton.OK, MessageBoxImage.Information);

            }
        }

        private void Cmd_Course_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int x = Convert.ToInt32(Cmd_Course.SelectedValue);
            Cmd_Group.ItemsSource = ClassDataBase.DBProjectJournal.Group.Where(y => y.Id == x).ToList();
        }

        private void Cmd_Spec_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
    }
