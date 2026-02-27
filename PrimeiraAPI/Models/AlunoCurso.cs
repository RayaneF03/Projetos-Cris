namespace PrimeiraAPI.Models
{
    public class AlunoCurso
    {
        //identiicador unico do registro para associar um aluno a um curso
        public Guid AlunoCursoId { get; set; }

        //chave estrangeira para o aluno
        public Guid AlunoId { get; set; }

        //propriedade de navegação para o aluno
        public Aluno? Aluno { get; set; }

        //chave estrangeira para o curso
        public Guid CursoId { get; set; }

        //propriedade de navegação para o curso
        public Curso? Curso { get; set; }

        //propriedade de navegação para n:m com a entidade Aluno
      

    }
}
