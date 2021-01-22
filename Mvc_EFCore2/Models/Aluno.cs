using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc_EFCore2.Models
{
    [Table("Alunos")]
    public class Aluno
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Nome { get; set; }
        [StringLength(50)]
        public string Sexo { get; set; }
        [StringLength(150)]
        public string Email { get; set; }
        public DateTime Nascimento { get; set; }
        [Required]
        [StringLength(150)]
        public string Foto { get; set; }
        [Required]
        [StringLength(150)]
        public string Texto { get; set; }

        public TipoSocio TipoSocio { get; set; }

    }
}
