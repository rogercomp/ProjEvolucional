using MediatR;
using System;

namespace DevEvolucional.Application.Commands.CreateUser
{
    public class CreateUserCommand : IRequest<int>
    {
        public string Senha { get; set; }
        public string Login { get; set; }

    }
}
