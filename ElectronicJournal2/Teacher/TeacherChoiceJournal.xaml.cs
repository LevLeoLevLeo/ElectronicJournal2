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
    /// Логика взаимодействия для TeacherChoiceJournal.xaml
    /// </summary>
    public partial class TeacherChoiceJournal : Page
    {
        public TeacherChoiceJournal()
        {
            InitializeComponent();

            Cmd_Course.SelectedValuePath = "Id";
            Cmd_Course.DisplayMemberPath = "Course";
            Cmd_Course.ItemsSource = ClassDataBase.DBProjectJournal.Cousre.ToList(); //Заполнение cmb курсов.
            
            Cmd_Group.SelectedValuePath = "Id";
            Cmd_Group.DisplayMemberPath = "NameGroup";
            Cmd_Group.ItemsSource = ClassDataBase.DBProjectJournal.Group.ToList(); //Заполнение cmb групп.

            Cmd_Subject.SelectedValuePath = "Id";
            Cmd_Subject.DisplayMemberPath = "NameDiscipline";
            Cmd_Subject.ItemsSource = ClassDataBase.DBProjectJournal.Discipline.ToList(); //Заполнение cmb дисциплин.

        }

        private void Cmd_Course_SelectionChanged(object sender, SelectionChangedEventArgs e) //Заполнение cmb групп после выбора курса.
        {
            int x = Convert.ToInt32(Cmd_Course.SelectedValue);
            Cmd_Group.ItemsSource = ClassDataBase.DBProjectJournal.Group.Where(y => y.IdCourse == x).ToList();

        }

        private void Btn_FollowToJournal_Click(object sender, RoutedEventArgs e) //Переход к электронному журналу.
        {

            if (Cmd_Group.SelectedValuePath == null || Cmd_Subject.SelectedValuePath == null) //Если информация где-то не заполнена.

            {

                MessageBox.Show("Вы что-то не выбрали.", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);

            }

            else //Переход в электронный журнал.

            {
                ClassDataBase.SavePathGroup = Convert.ToInt32(Cmd_Group.SelectedValue);
                ClassDataBase.SavepathDiscipline = Convert.ToInt32(Cmd_Subject.SelectedValue);
                WindowsFrames.FrmNavPanel.Navigate(new PageListEvaluation());

            }

        }
    }
}
