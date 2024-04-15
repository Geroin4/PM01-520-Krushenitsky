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

namespace MeropriatiyaKrush.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        
        List<Мероприятия> MeroDeskrp;
        List<Организаторы> Org;
        public MainPage()
        {
            InitializeComponent();
            DataGridUser.ItemsSource = Entities1.GetContext().Мероприятия.ToList();
            Entities1.GetContext();
        }
        private void DataGridUser_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MeroDeskrp = Entities1.GetContext().Мероприятия.ToList();
            Txb1.Text = MeroDeskrp[DataGridUser.SelectedIndex].Событие;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MeroDeskrp = Entities1.GetContext().Мероприятия.ToList();
            Txb1.Text = MeroDeskrp[DataGridUser.SelectedIndex].DATE.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MeroDeskrp = Entities1.GetContext().Мероприятия.ToList();
            using (var db = new Entities1())
            {
                
            } 
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Org = Entities1.GetContext().Организаторы.ToList();
            Txb1.Text = Org[DataGridUser.SelectedIndex].ФИО;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new AuthPage());
        }
    }
}
