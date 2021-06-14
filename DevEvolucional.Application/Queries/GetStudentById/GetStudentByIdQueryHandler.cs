using DevEvolucional.Application.ViewModels;
using DevEvolucional.Core.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace DevEvolucional.Application.Queries.GetStudentById
{

    public class GetStudentByIdQueryHandler : IRequestHandler<GetStudentByIdQuery, AlunoViewModel>
    {
        private readonly IAlunoRepository _alunoRepository;
        public GetStudentByIdQueryHandler(IAlunoRepository alunoRepository)
        {
            _alunoRepository = alunoRepository;
        }

        public async Task<AlunoViewModel> Handle(GetStudentByIdQuery request, CancellationToken cancellationToken)
        {
            var aluno = await _alunoRepository.GetByIdAsync(request.Id);

            if (aluno == null) return null;

            var alunoViewModel = new AlunoViewModel(
                aluno.Id,               
                aluno.Nome             
                );

            return alunoViewModel;
        }
    }
}
