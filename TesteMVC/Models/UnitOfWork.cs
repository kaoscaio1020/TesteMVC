using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteMVC.Data;

namespace TesteMVC.Models
{
    public class UnitOfWork : IDisposable
    {
        private bool disposed = false;
        private TesteMVCContext context;
        private SelecaoRepository selecaoRepository;
        private JogadorRepository jogadorRepository;

        public JogadorRepository JogadorRepository
        {
            get
            {
                if(jogadorRepository == null)
                {
                    jogadorRepository = new JogadorRepository(context);
                }
                return jogadorRepository;
            }
        }
        public SelecaoRepository SelecaoRepository
        {
            get
            {
                if (jogadorRepository == null)
                {
                    jogadorRepository = new JogadorRepository(context);
                }
                return selecaoRepository;
            }
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
