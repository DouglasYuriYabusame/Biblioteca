using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaVesp.Models
{
    [Table("livro")]
    public class Livro
    {
        [Key]
        [Column("idlivro")]
        public Int32 Idlivro { get; set; }
        [Column("nome")]
        public String Nome { get; set; }
        [Column("autor")]
        public String Autor { get; set; }
        [Column("idamigo")]
        public Int32 Idamigo { get; set; }

    }
}
