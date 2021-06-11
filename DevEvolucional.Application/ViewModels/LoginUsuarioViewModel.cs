namespace DevEvolucional.Application.ViewModels
{
    public class LoginUsuarioViewModel
    {
        public LoginUsuarioViewModel(string login, string token)
        {
            Login = login;
            Token = token;
        }

        public string Login { get; private set; }
        public string Token { get; private set; }
    }
}
