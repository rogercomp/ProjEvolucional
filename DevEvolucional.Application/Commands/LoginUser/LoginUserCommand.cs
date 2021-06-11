using DevEvolucional.Application.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEvolucional.Application.Commands.LoginUser
{
    public class LoginUserCommand : IRequest<LoginUsuarioViewModel>
    {
        public string Login { get; set; }
        public string Senha { get; set; }
    }
}
