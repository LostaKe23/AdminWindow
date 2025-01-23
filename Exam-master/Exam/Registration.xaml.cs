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
using System.Windows.Shapes;
namespace Exam
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {

        AppContext appContext = new AppContext();


        public Registration()
        {
            InitializeComponent();
            

            
        }

        private void Reg (object sender, RoutedEventArgs e)
        {
            // гарантируем, что база данных создана
            appContext.Database.EnsureCreated();
            
        }

        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {
            string login = loginTextBox.Text;
            string pass = passTextBox.Password;
            string password = passwordTextBox.Password;
            string email = emailTextBox.Text.ToLower();

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
            else if (pass != password)
            {
                passwordTextBox.ToolTip = "Пароли не совпадают";
                passwordTextBox.Background = Brushes.Red;
            }
            else if (email.Length < 5 || !email.Contains("@") || !email.Contains("."))
            {
                emailTextBox.ToolTip = "Короткий Email или отсутствуют символы '@','.'";
                emailTextBox.Background = Brushes.Red;
            }
            else
            {
                loginTextBox.ToolTip = "";
                loginTextBox.Background = Brushes.Transparent;
                passTextBox.ToolTip = "";
                passTextBox.Background = Brushes.Transparent;
                passwordTextBox.ToolTip = "";
                passwordTextBox.Background = Brushes.Transparent;
                emailTextBox.ToolTip = "";
                emailTextBox.Background = Brushes.Transparent;

                MessageBox.Show("Вы зарегистрированы!");

                User user = new User(login, pass, email);
                appContext.Add(user);
                appContext.SaveChanges();

                
            }

        }
    }
}
