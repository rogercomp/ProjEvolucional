using DevEvolucional.Application.ViewModels;
using MediatR;

namespace DevEvolucional.Application.Queries.GetUser
{
    public class GetUserQuery : IRequest<UsuarioViewModel>
    {
        public GetUserQuery(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}
