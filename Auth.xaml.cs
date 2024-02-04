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
using LoginISP;

namespace LoginISP
{
    public partial class Auth : ContentControl
    {

        public Auth()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            var user = ClassDB.entity.User.Where(i => i.Login == txbLogin.Text && i.Password == psbPassword.Password).FirstOrDefault();

            if (user.IdRole == 1)
            {
                ClassFrame.frameMenu.Content = new frameAdmin();
            }

            else if (user.IdRole == 2)
            {
                ClassFrame.frameMenu.Content = new frameUser();
            }
            else
            {
                MessageBox.Show("Ошибка! Неправильно введен логин или пароль");
            }
        }
    }
}
