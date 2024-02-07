using Simple_App_WPF_MVVM.Models;

namespace Simple_App_WPF_MVVM.ViewModels
{
    internal class LoginVM
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
            set { user.UserName = value; }
        }

        public string Password
        {
            get { return user.Password; }
            set { user.Password = value; }
        }


    }
}
