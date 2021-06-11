using System;
using System.Collections.Generic;
using System.Text;

namespace DevEvolucional.Application.ViewModels
{
    public class DisciplinaViewModel
    {
        public DisciplinaViewModel(int id, string descricao)
        {
            Id = id;
            Descricao = descricao;
        }

        public int Id { get; private set; }
        public string Descricao { get; private set; }
    }
}

