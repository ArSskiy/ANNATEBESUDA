using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для AddActivityPage.xaml
    /// </summary>
    public partial class AddActivityPage : Page
    {
        public AddActivityPage()
        {
            InitializeComponent();
            DirectionCmb.SelectedValuePath = "ID";
            DirectionCmb.DisplayMemberPath = "Name";
            DirectionCmb.ItemsSource = App.ent.Direction.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Activity activity = new Activity()
            {
                Name = ActivityTB.Text,
                Direction = DirectionCmb.SelectedItem as Direction

            };
            App.ent.Activity.Add(activity);
            App.ent.SaveChanges();
            MessageBox.Show("Активность добавлена!");
        }
    }
}
