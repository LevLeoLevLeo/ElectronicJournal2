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
using ElectronicJournal2.DataBase;

namespace ElectronicJournal2.Teacher
{
    /// <summary>
    /// Логика взаимодействия для PafeAddElevation.xaml
    /// </summary>
    public partial class PafeAddElevation : Page
    {
        public PafeAddElevation()
        {
            InitializeComponent();

            Cmb_Course.SelectedValuePath = "Id";
            Cmb_Course.DisplayMemberPath = "Course";
            Cmb_Course.ItemsSource = ClassDataBase.DBProjectJournal.Cousre.ToList();

            Cmb_Group.SelectedValuePath = "Id";
            Cmb_Group.DisplayMemberPath = "NameGroup";
            Cmb_Group.ItemsSource = ClassDataBase.DBProjectJournal.Group.ToList();

            Cmb_Student.SelectedValuePath = "Id";
            Cmb_Student.DisplayMemberPath = "Name";
            Cmb_Student.ItemsSource = ClassDataBase.DBProjectJournal.Student.ToList();

            Cmb_Object.SelectedValuePath = "Id";
            Cmb_Object.DisplayMemberPath = "NameDiscipline";
            Cmb_Object.ItemsSource = ClassDataBase.DBProjectJournal.Discipline.ToList();
        }

        private void Cmb_Course_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int x = Convert.ToInt32(Cmb_Course.SelectedValue);
            Cmb_Group.ItemsSource = ClassDataBase.DBProjectJournal.Group.Where(y => y.IdCourse == x).ToList();
        }

        private void Btn_AddEvaluation_Click(object sender, RoutedEventArgs e)
        {
            if (Cmb_Object.SelectedItem == null || Cmb_Group.SelectedItem == null || Cmb_Student.SelectedItem == null || Txb_Evaluation.Text == null)

            {

                MessageBox.Show("Вы что-то не выбрали", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);

            }

            else

            {

                if (Convert.ToInt32(Txb_Evaluation.Text) < 2 || Convert.ToInt32(Txb_Evaluation.Text) > 5)

                {

                    MessageBox.Show("Введена некорректная оценка", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);

                }

                else

                {

                    Evaluation evaluationobj = new Evaluation()

                    {

                        Discipline = Cmb_Object.SelectedItem as Discipline,
                        Student = Cmb_Student.SelectedItem as Student,
                        Group = Cmb_Group.SelectedItem as Group,
                        Evaluation1 = Convert.ToInt32(Txb_Evaluation.Text),

                    };

                    ClassDataBase.DBProjectJournal.Evaluation.Add(evaluationobj);
                    ClassDataBase.DBProjectJournal.SaveChanges();
                    MessageBox.Show("Оценка поставлена!", "Оценка", MessageBoxButton.OK, MessageBoxImage.Information);

                }
            }
        }

        private void Cmb_Group_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int x = Convert.ToInt32(Cmb_Group.SelectedValue);
            Cmb_Student.ItemsSource = ClassDataBase.DBProjectJournal.Student.Where(y => y.IdGroup == x).ToList();
        }
    }
}
