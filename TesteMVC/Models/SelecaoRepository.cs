using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteMVC.Data;

namespace TesteMVC.Models
{
    public class SelecaoRepository : IDisposable
    {
        private bool disposed = false;

        private TesteMVCContext context;

        public SelecaoRepository(TesteMVCContext context)
        {
            this.context = context;
        }
        public void Adiciona(Selecao selecao)
        {
            context.Selecoes.Add(selecao);
        }

        public List<Selecao> Selecoes
        {
            get { return context.Selecoes.ToList(); }
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
