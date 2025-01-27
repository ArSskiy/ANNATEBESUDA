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

namespace Control8
{
    /// <summary>
    /// Логика взаимодействия для Uchet1.xaml
    /// </summary>
    public partial class Uchet1 : Page
    {
        public Uchet1()
        {
            InitializeComponent();
            EmployeCmb.SelectedValuePath = "ID";
            EmployeCmb.DisplayMemberPath = "Name";
            EmployeCmb.ItemsSource = App.ent.Group.ToList();
        }

        private void DatGr_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int selectGroup = Convert.ToInt32(EmployeCmb.SelectedValue);
            var a = (DateTime)StartDP.SelectedDate;
            var b = (DateTime)EndDP.SelectedDate;
            DatGr.ItemsSource = App.ent.Journal.Where(x => x.IdGroup == selectGroup).Where(y => y.DateEvent >= a && y.DateEvent <= b).ToList();

            var CountRecording = App.ent.Journal.Where
                (x => x.IdGroup == selectGroup).Count();
            

            var SumMark = App.ent.Journal.Where
                (x => x.IdGroup == selectGroup).
                Select(y => y.Mark).Sum();
            TC.Text = Convert.ToString(SumMark / CountRecording);
        }
    }
}
