using DevEvolucional.Core.Entities;
using DevEvolucional.Core.Services;
using DevEvolucional.Infrastructure.Persistence;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace DevEvolucional.Application.Commands.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, int>
    {
        private readonly DevEvolucionalDbContext _dbContext;
        private readonly IAuthService _authService;
        public CreateUserCommandHandler(DevEvolucionalDbContext dbContext, IAuthService authService)
        {
            _dbContext = dbContext;
            _authService = authService;
        }

        public async Task<int> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var passwordHash = _authService.ComputeSha256Hash(request.Senha);

            var user = new Usuario(request.Login, passwordHash);

            await _dbContext.Usuarios.AddAsync(user);
            await _dbContext.SaveChangesAsync();

            return user.Id;
        }
    }
}
