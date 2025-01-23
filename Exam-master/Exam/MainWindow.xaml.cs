using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Exam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();

        }

        private void Button_Entrance_Click(object sender, RoutedEventArgs e)
        {
            string login = loginTextBox.Text;
            string pass = passTextBox.Password;
            

            if (login.Length < 5)
            {
                loginTextBox.ToolTip = "Слишком короткий логин";
                loginTextBox.Background = Brushes.Red;
            }
            else if (pass.Length < 5)
            {
                passTextBox.ToolTip = "Короткий пароль";
                passTextBox.Background = Brushes.Red;
            }
            else
            {
                loginTextBox.ToolTip = "";
                loginTextBox.Background = Brushes.Transparent;
                passTextBox.ToolTip = "";
                passTextBox.Background = Brushes.Transparent;

                User authUser = null;
                using (AppContext context = new AppContext())
                {
                    authUser  = context.Users.Where(user => user.Login == login && user.Password == pass).FirstOrDefault();
                }
                if (authUser != null)
                {
                    MessageBox.Show("Добро Пожаловать!");
                }
                else
                {
                    MessageBox.Show("Пользователь не найден!");
                }
            }
        }
    }
}