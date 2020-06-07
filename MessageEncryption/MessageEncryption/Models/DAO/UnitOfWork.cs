using MessageEncryption.Models.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MessageEncryption.Models.DAO
{
    public class UnitOfWork : IDisposable
    {
        private MsgEncContext context = new MsgEncContext();
        private GenericRepository<Replacement> replacementRepository;
        private GenericRepository<Message> messageRepository;

        public GenericRepository<Replacement> ReplacementRepository
        {
            get
            {

                if (this.replacementRepository == null)
                {
                    this.replacementRepository = new GenericRepository<Replacement>(context);
                }
                return replacementRepository;
            }
        }

        public GenericRepository<Message> MessageRepository
        {
            get
            {

                if (this.messageRepository == null)
                {
                    this.messageRepository = new GenericRepository<Message>(context);
                }
                return messageRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
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