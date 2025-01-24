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
    /// Логика взаимодействия для UchetPage.xaml
    /// </summary>
    public partial class UchetPage : Page
    {
        public UchetPage()
        {
            InitializeComponent();
            SpecialCmb.SelectedValuePath = "ID";
            SpecialCmb.DisplayMemberPath = "Name";
            SpecialCmb.ItemsSource = App.ent.Special.ToList();

            InitializeComponent();
            DirectionCmb.SelectedValuePath = "ID";
            DirectionCmb.DisplayMemberPath = "Name";
            DirectionCmb.ItemsSource = App.ent.Direction.ToList();
        }

        private void SpecialCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectSpecial = Convert.ToInt32(SpecialCmb.SelectedValue);
            GroupCmb.ItemsSource = App.ent.Group.Where(x => x.IdSpecial == selectSpecial).ToList();
        }

        private void DirectionCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectDirection = Convert.ToInt32(DirectionCmb.SelectedValue);
            ActivityCmb.ItemsSource = App.ent.Activity.Where(x => x.IdDirection == selectDirection).ToList();
        }
    }
}
