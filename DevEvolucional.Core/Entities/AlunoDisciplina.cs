namespace DevEvolucional.Core.Entities
{
    public class AlunoDisciplina : BaseEntity
    {
        public AlunoDisciplina(int idAluno, int idDisciplina)
        {
            IdAluno = idAluno;
            IdDisciplina = idDisciplina;
            //IdUser = idUser;
            //IdSkill = idSkill;
        }

        public int IdAluno { get; private set; }
        public int IdDisciplina { get; private set; }
        public Disciplina Disciplina { get; private set; }

        //public int IdUser { get; private set; }
        //public int IdSkill { get; private set; }
        //public Skill Skill { get; private set; }
    }
}
