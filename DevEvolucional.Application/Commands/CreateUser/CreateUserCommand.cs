using MediatR;
using System;

namespace DevEvolucional.Application.Commands.CreateUser
{
    public class CreateUserCommand : IRequest<int>
    {
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Role { get; set; }

    }
}
