namespace FibaroDotNetSDK.Infrastructure
{
    public class LoginData
    {
        public LoginData(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }

        public string UserName { get; }
        public string Password { get; }
    }
}