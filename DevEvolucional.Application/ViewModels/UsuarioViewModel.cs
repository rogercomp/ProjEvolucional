using System;
using System.Collections.Generic;
using System.Text;

namespace DevEvolucional.Application.ViewModels
{
    public class UsuarioViewModel
    {
        public UsuarioViewModel(string login, string senha)
        {
            Login = login;
            Senha = senha;
        }

        public string Login { get; private set; }
        public string Senha { get; private set; }
    }
}
