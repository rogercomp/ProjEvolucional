using System;
using System.Collections.Generic;
using System.Text;

namespace DevEvolucional.Application.ViewModels
{
    public class AlunoViewModel
    {
        public AlunoViewModel(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
    }
}
