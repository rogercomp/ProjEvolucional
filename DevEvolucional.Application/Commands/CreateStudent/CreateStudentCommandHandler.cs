using DevEvolucional.Core.Entities;
using DevEvolucional.Core.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace DevEvolucional.Application.Commands.CreateStudent
{

    public class CreateStudentCommandHandler : IRequestHandler<CreateStudentCommand, int>
    {
        private readonly IAlunoRepository _alunoRepository;
        public CreateStudentCommandHandler(IAlunoRepository alunoRepository)
        {
            _alunoRepository = alunoRepository;
        }

        public async Task<int> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
        {
            var aluno = new Aluno(request.Nome);

            await _alunoRepository.AddAsync(aluno);

            return aluno.Id;
        }
    }
}
