using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAzure.Models
{
    [Table("Usuario")]
    public class Usuario
    {


        [Column("Id")]
        [Display(Name = "Codigo")]
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Column("Idade")]
        [Display(Name = "Idade")]
        public int Idade { get; set; }
    }
}
