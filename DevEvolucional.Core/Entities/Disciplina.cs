using System;

namespace DevEvolucional.Core.Entities
{
    public class Disciplina : BaseEntity
    {
        public Disciplina(int id, string descricao) : base()
        {            
            Descricao = descricao;
            //Description = description;
            //CreatedAt = DateTime.Now;
        }
               
        public string Descricao { get; private set; }
        //public string Description { get; private set; }
        //public DateTime CreatedAt { get; private set; }
    }
}
