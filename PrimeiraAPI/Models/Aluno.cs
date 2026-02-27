using System.ComponentModel.DataAnnotations;

namespace PrimeiraAPI.Models
{
    public class Aluno
    {
        public Guid AlunoId { get; set; } // Identificador único do aluno
        [Required]
        public string? Nome { get; set; } // Nome do aluno
        public DateOnly DataNascimento { get; set; } // Data de nascimento do aluno.
        public int RM { get; set; } // Registro do aluno
        public bool? CadastroAtivo { get; set; } // Indica se o cadastro do aluno está ativo ou inativo
        public decimal Mensalidade { get; set; } // Valor da mensalidade do aluno
        public DateTime? DataCadastro { get; set; } // Data de cadastro do aluno (opcional)

        //propriedade de navegação para n:m com a entidade Curso
        public ICollection<Curso> cursos { get; set; } = new List<Curso>(); // Lista de cursos associados ao aluno (inicializada como uma lista vazia)
    }
}
