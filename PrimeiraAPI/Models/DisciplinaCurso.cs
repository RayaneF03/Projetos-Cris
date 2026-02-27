namespace PrimeiraAPI.Models
{
    public class DisciplinaCurso
    {
        // Identificador único do registro da associação entre Disciplina e Curso
        public Guid DisciplinaCursoId { get; set; }
        // Chave estrangeira para a Disciplina
        public Guid DisciplinaId { get; set; }
        //Propriedade de navegação para a Disciplina
        public Disciplina? Disciplina { get; set; }
        // Chave estrangeira para o Curso
        public Guid CursoId { get; set; }
        // Propriedade de navegação para o Curso
        public Curso? Curso { get; set; }
    }
}
