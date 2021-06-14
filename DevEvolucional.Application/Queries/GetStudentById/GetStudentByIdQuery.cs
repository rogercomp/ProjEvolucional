using DevEvolucional.Application.ViewModels;
using MediatR;

namespace DevEvolucional.Application.Queries.GetStudentById
{
    public class GetStudentByIdQuery : IRequest<AlunoViewModel>
    {
        public GetStudentByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}
