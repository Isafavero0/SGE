using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGE.Models
{
    [Table("Alunos")]
    public class Alunos
    {
        [Column("Id")]
        [Display(Name = "Id do aluno")]
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome do aluno")]
        public string Nome { get; set; } =string.Empty;    

        [Column("CPF")]
        [Display(Name = "CPF do aluno")]
        public string CPF { get; set; } =string.Empty;

        [Column("Email")]
        [Display(Name = "Email do aluno")]
        public string Email { get; set; } = string.Empty;

        [Column("Telefone")]
        [Display(Name = "Telefone do aluno")]
        public string Telefone { get; set; } = string.Empty;

        [Column("DataNascimento")]
        [Display(Name = "Data de nascimento do aluno")]
        public string DataNascimento { get; set; } = string.Empty;
    }
}
