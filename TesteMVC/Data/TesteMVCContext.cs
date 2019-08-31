using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TesteMVC.Models;

namespace TesteMVC.Data
{
    public class TesteMVCContext :DbContext
    {
        public TesteMVCContext(DbContextOptions<TesteMVCContext> options) : base(options)
        {

        }
        public DbSet<Selecao> Selecoes { get; set; }
        public DbSet<Jogador> Jogadores { get; set; }
    }
}
