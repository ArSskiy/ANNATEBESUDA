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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Control8
{
    /// <summary>
    /// Логика взаимодействия для AddGroupPage.xaml
    /// </summary>
    public partial class AddGroupPage : Page
    {
        public AddGroupPage()
        {
            InitializeComponent();
            SpecialCmb.SelectedValuePath = "ID";
            SpecialCmb.DisplayMemberPath = "Name";
            SpecialCmb.ItemsSource = App.ent.Special.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Group group = new Group()
            {
                Name = GroupTB.Text,
                Special = SpecialCmb.SelectedItem as Special

            };
            App.ent.Group.Add(group);
            App.ent.SaveChanges();
            MessageBox.Show("Группа добавлена!");
        }
    }
}
