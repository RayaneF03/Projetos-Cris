using System.ComponentModel.DataAnnotations;

namespace PrimeiraAPI.Models
{
    public class Disciplina
    {
        public Guid DisciplinaId { get; set; }
        [Required]
        public string Nome { get; set; }
        //semestre sugerido
        public int? Semestre { get; set; }
        //carga horaria
        public int CargaHoraria { get; set; }

        // Propriedade de navegação para a relação N:M com Curso
        public ICollection<Curso> Cursos { get; set; } = new List<Curso>();


    }
}
