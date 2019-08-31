using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteMVC.Data;

namespace TesteMVC.Models
{
    public class JogadorRepository : IDisposable
    {
        private bool disposed = false;

        private TesteMVCContext context;

        public JogadorRepository(TesteMVCContext context)
        {
            this.context = context;
        }

        public void Adiciona(Jogador jogador)
        {
            context.Jogadores.Add(jogador);
        }

        public List<Jogador> Jogador
        {
            get { return context.Jogadores.ToList(); }
        }

        public void Salva()
        {
            context.SaveChanges();
        }

        protected void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
}
