using DevEvolucional.Application.ViewModels;
using MediatR;
using System.Collections.Generic;

namespace DevEvolucional.Application.Queries
{

    public class GetAllStudentsQuery : IRequest<List<AlunoViewModel>>
    {
        public GetAllStudentsQuery(string query)
        {
            Query = query;
        }

        public string Query { get; private set; }
    }
}
