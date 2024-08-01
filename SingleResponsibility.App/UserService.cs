namespace SingleResponsibility.App
{
    public class UserLoginService
    {
        public User Login(string userName, string password)
        {
            //Do login
            return new User();
        }

        public void SendEmail(User user, string message)
        {
            //Send Email to User
        }
    }
}
