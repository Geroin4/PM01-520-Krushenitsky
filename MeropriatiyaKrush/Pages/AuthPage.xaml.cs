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
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
        }





        private void Frame_Navigated(object sender, NavigationEventArgs e)

        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            using (var db = new Entities1())
            {
                switch (CmbRole.SelectedIndex)
                {
                    case 1:
                        var user = db.Жюри
                        .AsNoTracking()
                        .FirstOrDefault(u => u.ФИО == Txb.Text && u.Пароль.ToString() == PBox.Password);

                        if (user == null)
                        {
                            MessageBox.Show("Жюри с таким данными не найден!");
                            return;
                        }
                        if (user != null)
                        {
                            MessageBox.Show("Жюри найден!");
                            NavigationService?.Navigate(new JuryPage());
                        }
                        break;
                    case 0:
                        var user2 = db.Участники
                        .AsNoTracking()
                        .FirstOrDefault(u => u.ФИО == Txb.Text && u.пароль.ToString() == PBox.Password);

                        if (user2 == null)
                        {
                            MessageBox.Show("Участник с таким данными не найден!");
                            return;
                        }
                        if (user2 != null)
                        {
                            MessageBox.Show("Участник найден!");
                            NavigationService?.Navigate(new Userpage());
                        }

                        break;

                }





            }
        }

        private void Txb_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtHintLogin.Visibility = Visibility.Visible;

            if (Txb.Text.Length > 0)

            {

                txtHintLogin.Visibility = Visibility.Hidden;

            }
        }
        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            txtHintPassword.Visibility = Visibility.Visible;
            if (PBox.Password.ToString().Length > 0)

            {

                txtHintPassword.Visibility = Visibility.Hidden;

            }
        }
    }
}
