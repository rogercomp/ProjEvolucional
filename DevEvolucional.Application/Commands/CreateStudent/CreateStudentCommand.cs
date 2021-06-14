using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEvolucional.Application.Commands.CreateStudent
{
    public class CreateStudentCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
