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

namespace MeropriatiyaKrush
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Closing += Window_Closing;
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)

        {
            MessageBoxResult result = MessageBox.Show("Вы уверены, что хотите закрыть окно?", "Подтверждение закрытия", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.No)

            {

                e.Cancel = true; 

            }

        }
        private void MainFrame_OnNavigated(object sender, NavigationEventArgs e)
        {
            if (!(e.Content is Page page)) return;
            

            if (page is Pages.MainPage)
                Backbtn.Visibility = Visibility.Hidden;
            else
                Backbtn.Visibility = Visibility.Visible;
        }
        private void Backbtn_Click(object sender, RoutedEventArgs e)
        {
            Fr.GoBack();
        }
    }
}
