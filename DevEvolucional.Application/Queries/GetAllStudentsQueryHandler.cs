using DevEvolucional.Application.ViewModels;
using DevEvolucional.Core.Repositories;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DevEvolucional.Application.Queries
{

    public class GetAllStudentsQueryHandler : IRequestHandler<GetAllStudentsQuery, List<AlunoViewModel>>
    {
        private readonly IAlunoRepository _alunoRepository;
        public GetAllStudentsQueryHandler(IAlunoRepository alunoRepository)
        {
            _alunoRepository = alunoRepository;
        }

        public async Task<List<AlunoViewModel>> Handle(GetAllStudentsQuery request, CancellationToken cancellationToken)
        {
            var alunos = await _alunoRepository.GetAllAsync();

            var alunosViewModel = alunos
                .Select(p => new AlunoViewModel(p.Id, p.Nome))
                .ToList();

            return alunosViewModel;
        }
    }
}
