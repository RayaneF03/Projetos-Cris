using System.ComponentModel.DataAnnotations;

namespace PrimeiraAPI.Models
{
    public class Curso
    {
        public Guid CursoId { get; set; }
        public string Nome { get; set; }
        public int Semestres { get; set; }
        public bool? Ativo { get; set; }
        [DataType(DataType.Currency)]
        public decimal Mensalidade { get; set; }
        public ICollection<Aluno> alunos { get; set; } = new List<Aluno>(); // Lista de cursos associados ao aluno (inicializada como uma lista vazia)
    }
}
