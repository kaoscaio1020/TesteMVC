using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TesteMVC.Models
{
    [Table("Jogadores")]
    public class Jogador
    {
        public int Id { get; set; }
        public string NOme { get; set; }
        public string Posicao { get; set; }
        public DateTime Nascimento { get; set; }
        public Double Autura { get; set; }
        public int SelecaoId { get; set; }
        [InverseProperty("Jogadores")]
        public Selecao Selecao { get; set; }
    }
}
