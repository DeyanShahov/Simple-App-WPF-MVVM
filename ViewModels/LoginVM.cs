using Simple_App_WPF_MVVM.Models;

namespace Simple_App_WPF_MVVM.ViewModels
{

    internal class LoginVM : ViewModelBase
    {
        private User user;
        private string userName;

        public LoginVM()
        {
            user = new User();
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

      
    }
}
