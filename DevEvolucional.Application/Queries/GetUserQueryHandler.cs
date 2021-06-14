using DevEvolucional.Application.Queries.GetUser;
using DevEvolucional.Application.ViewModels;
using DevEvolucional.Core.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace DevEvolucional.Application.Queries
{
    public class GetUserQueryHandler : IRequestHandler<GetUserQuery, UsuarioViewModel>
    {
        private readonly IUsuarioRepository _userRepository;
        public GetUserQueryHandler(IUsuarioRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<UsuarioViewModel> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetByIdAsync(request.Id);

            if (user == null)
            {
                return null;
            }

            return new UsuarioViewModel(user.Login, user.Senha);
        }
    }
}
