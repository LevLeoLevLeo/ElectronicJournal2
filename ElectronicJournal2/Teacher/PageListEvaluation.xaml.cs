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
    /// Логика взаимодействия для PageListEvaluation.xaml
    /// </summary>
    public partial class PageListEvaluation : Page
    {
        public PageListEvaluation()
        {
            InitializeComponent();

            ListEvaluation.ItemsSource = ClassDataBase.DBProjectJournal.Evaluation.Where(y => y.IdGroup == ClassDataBase.SavePathGroup && y.IdDiscipline == ClassDataBase.SavepathDiscipline).ToList();

        }
    }
}
