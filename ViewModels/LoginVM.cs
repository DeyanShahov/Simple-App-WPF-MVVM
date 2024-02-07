using Simple_App_WPF_MVVM.Commands;
using Simple_App_WPF_MVVM.Models;
using System.Windows;
using System.Windows.Input;

namespace Simple_App_WPF_MVVM.ViewModels
{

    internal class LoginVM : ViewModelBase
    {
        private User user;
        private string userName;
        public ICommand LoginCommand { get;}

        public LoginVM()
        {
            user = new User();
            LoginCommand = new RelayCommand((param) => LoggedIn(param));
        }

        public string UserName
        {
            get { return user.UserName; }
            set {
                user.UserName = value; 
                OnPropertyChanged(nameof(UserName));
                }
        }

        public string Password
        {
            get { return user.Password; }
            set { 
                user.Password = value;
                OnPropertyChanged(nameof(Password));
                }
        }

        private void LoggedIn(object param)
        {
            MessageBox.Show($"Logged in SuccessFull as {param}");
        }

    }
}
