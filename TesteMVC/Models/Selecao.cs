using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TesteMVC.Models
{
    [Table("Selecoes")]
    public class Selecao
    {
        public int Id { get; set; }
        public string Pais { get; set; }
        public string Tecnico { get; set; }
        public List<Jogador> Jogadores { get; set; }
    }
}
