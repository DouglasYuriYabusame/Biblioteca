using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaVesp.Models
{
    [Table("amigo")]
    public class Amigo
    {
        [Key]
        [Column("idamigo")]
        public Int32 Idamigo { get; set; }
        [Column("nome")]
        public String Nome { get; set; }
    }
}
