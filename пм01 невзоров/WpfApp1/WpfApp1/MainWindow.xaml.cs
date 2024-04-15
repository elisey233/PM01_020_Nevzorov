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
using WpfApp1;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Здесь можно добавить код для загрузки данных о мероприятиях и отображения их в главном окне
        }

        private void FilterByDirectionButton_Click(object sender, RoutedEventArgs e)
        {
            // Код для фильтрации мероприятий по направлению
        }

        private void FilterByDateButton_Click(object sender, RoutedEventArgs e)
        {
            // Код для фильтрации мероприятий по дате
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string idNumber = IdNumberTextBox.Text;
            string password = PasswordBox.Password;

            // Код для проверки учетных данных и перехода на соответствующее окно в зависимости от роли пользователя
            // Включая проверку CAPTCHA и блокировку системы

            // Пример перехода на окно организатора
        }
    }
}
