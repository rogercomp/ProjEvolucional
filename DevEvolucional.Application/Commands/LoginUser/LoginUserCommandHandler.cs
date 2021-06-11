using DevEvolucional.Application.ViewModels;
using DevEvolucional.Core.Repositories;
using DevEvolucional.Core.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DevEvolucional.Application.Commands.LoginUser
{
    public class LoginUserCommandHandler : IRequestHandler<LoginUserCommand, LoginUsuarioViewModel>
    {
        private readonly IAuthService _authService;
        private readonly IUsuarioRepository _usuarioRepository;
        public LoginUserCommandHandler(IAuthService authService, IUsuarioRepository usuarioRepository)
        {
            _authService = authService;
            _usuarioRepository = usuarioRepository;
        }

        public async Task<LoginUsuarioViewModel> Handle(LoginUserCommand request, CancellationToken cancellationToken)
        {
            // Utilizar o mesmo algoritmo para criar o hash dessa senha
            var passwordHash = _authService.ComputeSha256Hash(request.Senha);

            // Buscar no meu banco de dados um User que tenha meu e-mail e minha senha em formato hash
            var user = await _usuarioRepository.GetUserByEmailAndPasswordAsync(request.Login, passwordHash);

            // Se nao existir, erro no login
            if (user == null)
            {
                return null;
            }

            // Se existir, gero o token usando os dados do usuário
            var token = _authService.GenerateJwtToken(user.Login);

            return new LoginUsuarioViewModel(user.Login, token);
        }
    }
}
