using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_MySQL.Models
{
    [Table ("Usuario")]

    public class Usuario
    {
        [Display(Name = "Código")]
        [Column("ID")]
        public int ID { get; set; }

        [Display(Name = "Nome")]
        [Column("Nome")]
        public string Nome { get; set; }

        [Display(Name = "RG")]
        [Column("RG")]
        public string RG { get; set; }

        [Display(Name = "Email")]
        [Column("Email")]
        public string Email { get; set; }
    }
}
